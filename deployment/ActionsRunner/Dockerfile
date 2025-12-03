FROM ubuntu:24.04
RUN apt-get update
RUN apt-get install -y --no-install-recommends software-properties-common
RUN add-apt-repository ppa:dotnet/backports
RUN add-apt-repository ppa:ansible/ansible
RUN apt-get install -y --no-install-recommends dotnet-sdk-9.0 ansible
RUN apt-get install -y zip unzip sudo

COPY ./actions-runner /app/actions-runner

# Copy Ansible playbooks and inventory
COPY hosts.yaml /etc/ansible/hosts
COPY provision-test-env.yaml /etc/ansible/provision-test-env.yaml

ARG USERNAME=appuser
ARG USER_UID=1234
ARG USER_GID=$USER_UID

RUN groupadd --gid $USER_GID $USERNAME \
  && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME

USER $USERNAME

RUN dotnet tool install --global Chickensoft.GodotEnv
ENV PATH="~/.dotnet/tools:${PATH}"

ENV TEMPLATE_VERSION="4.5.1.stable.mono"
ENV TEMPLATE_DIR="~/.local/share/godot/export_templates/$TEMPLATE_VERSION"
RUN mkdir -p "$TEMPLATE_DIR"
RUN curl -L "https://github.com/godotengine/godot/releases/download/4.5.1-stable/Godot_v4.5.1-stable_mono_export_templates.tpz" -o /tmp/templates.tpz
RUN unzip -o /tmp/templates.tpz -d /tmp/templates
RUN mv /tmp/templates/templates/* "$TEMPLATE_DIR/"
RUN rm -rf /tmp/templates /tmp/templates.tpz

ENTRYPOINT ["/app/actions-runner/run.sh"]
