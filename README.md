# Usage
To build the image
> Cd to the folder where there is a .sln file and the dockerfile. The dockerfile and the .sln have to be in the same folder
> To build the image, run docker build -t <image-name> . This will create an image from the dockerfile
> To build a container, run docker run docker -p <host-port>:80 <image-name>. For some reasons, the application inside only listens to port 80
> The url of the application is "localhost:<host-port>"