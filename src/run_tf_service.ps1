docker run --name facedb -e POSTGRES_PASSWORD=admin -e POSTGRES_USER=admin -d -p 5432:5432 postgres:alpine

docker run -d -t --rm -p 8501:8501 -p 8500:8500  -v D:/docker/volumes/tf/siamese_network_face:/models/siamese_network_face -e MODEL_NAME=siamese_network_face tensorflow/serving