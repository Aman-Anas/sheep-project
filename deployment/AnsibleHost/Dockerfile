FROM python:3.12-slim

# Install Ansible and common dependencies
RUN pip install --no-cache-dir ansible

# Working directory where playbooks will be mounted
WORKDIR /ansible

# Default command
CMD ["bash"]