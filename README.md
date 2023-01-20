# Usage

* Cd to the folder where there is a .sln file and the dockerfile. The dockerfile and the .sln have to be in the same folder
* To build the image from the docker file

```bash
docker build -t <image-name> 
```

* To build a container, run

```bash
docker run -p <host-port>:80 <image-name>. 
```

For some reasons, the application inside only listens to port 80

* The url of the application is

```bash
localhost:<host-port>
```
