#!/bin/bash
docker build -f Dockerfile.UserMgmtServer -t usermgmtserver:latest 
docker run -i --rm -p 8080:8080 usermgmtserver:latest --http