# Status Report 2

## Accomplishments
**Aman:** 
- Migrated files from old repo to new repo in CSC-519 organization.
- Set up Github Actions runner on the durable deployment machine using a container and Dockerfile.
- Installed dotnet and other required tools on the deployment machine.

**Andrew:** 
- Added branch protection to new repo

## Next steps
**Aman:** 
- Work on implementing parts of the Ansible playbook used for deployment
- Work on developing test cases using GodotTest

**Andrew:** 

## Retrospective
**Aman:** 
- Setting up the Github Actions runners to work correctly took some configuration. Since we didn't have admin access to the deployment machine, I had to set up a dockerfile to run the runner inside of a dedicated container. This worked well, and so I'll probably also do the deployment of our application via Ansible into a container, so it's easy to install the prerequisite resources and software to run the game engine.

**Andrew:** 
