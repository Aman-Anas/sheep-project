#!/bin/bash
set -e

ANSIBLE_IMAGE="ansible-controller"
TARGET_IMAGE="ansible-target"
TARGET_CONTAINER="ansible-target-container"

echo "[1] Build Ansible controller container..."
docker build -t $ANSIBLE_IMAGE ./AnsibleHost

echo "[2] Build Ansible target container..."
docker build -t $TARGET_IMAGE ./AnsibleTarget

echo "[3] Start Ansible target container..."
docker rm -f $TARGET_CONTAINER 2>/dev/null || true
docker run -d --name $TARGET_CONTAINER $TARGET_IMAGE

sleep 3

echo "[4] Provision target container using Ansible controller..."
docker run --rm \
    --network="container:$TARGET_CONTAINER" \
    -v $(pwd)/AnsibleHost:/ansible \
    $ANSIBLE_IMAGE \
    ansible-playbook -i /ansible/hosts.yaml /ansible/provision-test-env.yaml

echo "[5] Finished provisioning!"