FROM ubuntu:24.04
RUN apt-get update
RUN apt-get install -y --no-install-recommends software-properties-common
RUN add-apt-repository ppa:dotnet/backports
RUN apt-get install -y --no-install-recommends \
  dotnet-sdk-9.0

COPY ./actions-runner /app/actions-runner

ARG USERNAME=appuser
ARG USER_UID=1234
ARG USER_GID=$USER_UID

RUN groupadd --gid $USER_GID $USERNAME \
  && useradd --uid $USER_UID --gid $USER_GID -m $USERNAME

USER $USERNAME

RUN dotnet tool install --global Chickensoft.GodotEnv
RUN export PATH="$PATH:$HOME/.dotnet/tools"

ENTRYPOINT ["/app/actions-runner/run.sh"]
