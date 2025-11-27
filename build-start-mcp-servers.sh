#!/bin/bash
rm -rf ./.data
docker build -f Dockerfile.UserMgmtServer -t usermgmtserver:latest .
docker run -d --rm -p 8080:8080 usermgmtserver:latest --http