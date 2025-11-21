# Status Report 2

## Accomplishments
**Aman:** 
- Migrated files from old repo to new repo in CSC-519 organization.
- Set up Github Actions runner on the durable deployment machine using a container and Dockerfile.
- Installed dotnet and other required tools on the deployment machine.
- See commit: https://github.ncsu.edu/CSC-519/f2025_project_sheep_project/pull/3/commits/a2c3116d33feb6d1beb826123a65b9f11270ccb4

**Andrew:** 
- Added branch protection to new repo
- Added rudimentary Ansible playbook for project test environment deployment
- Added rudimentary Dockerfiles for Ansible host and target containers
- See commit: https://github.ncsu.edu/CSC-519/f2025_project_sheep_project/commit/9d2cec78baabff584ac0dfaa53f691e79d4bf779

## Next steps
**Aman:** 
- Work on developing test cases using GodotTest
  - [Estimated: 2-3 days]

**Andrew:** 
- Work on implementing parts of the Ansible playbook used for deployment and ensuring the dotnet application builds. Ensure the containers are able to communicate with each other.
  - [Estimated: 3-4 days]

## Retrospective
**Aman:** 
- Setting up the Github Actions runners to work correctly took some configuration. Since we didn't have admin access to the deployment machine, I had to set up a dockerfile to run the runner inside of a dedicated container. This worked well, and so I'll probably also do the deployment of our application via Ansible into a container, so it's easy to install the prerequisite resources and software to run the game engine.

**Andrew:** 
- Thinking through how we were going to use Ansible to deploy our testing environment took some time. It looks like we will end up having multiple Docker containers on one machine to act as the Ansible host and target machines, in addition to the GitHub Actions runners. It will take some time to think about how to get the containers to talk to each other since they're on the same machine. Port forwarding could be the way to go, or there may be a better solution.