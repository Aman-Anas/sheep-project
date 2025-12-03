FROM ubuntu:24.04
RUN apt-get update
RUN apt-get install -y --no-install-recommends ansible

COPY ./actions-runner /app/actions-runner

ARG USERNAME=appuser
ARG USER_UID=1234
ARG USER_GID=$USER_UID

RUN groupadd --gid $USER_GID $USERNAME \
    && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME

USER $USERNAME
RUN ansible-playbook -i hosts.yaml provision-test-env.yaml
