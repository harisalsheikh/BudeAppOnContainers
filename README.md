# BudeAppOnContainers
Running .Net Application On Containers

# Run Application On Docker Container
## Pre-req

- Download Docker Desktop

## Run the following commands to run the application 

- Clone directory 
- Chnage directory to the BudgetAppOnContainers folder 
- docker build -t budget-container-app .
- docker run -d -p 8080:80 budget-container-app
- Open browser and browse to http://localhost:8080

<img width="1513" alt="image" src="https://user-images.githubusercontent.com/64015837/209667941-ad42e8c1-cf31-4326-85bf-ec817567abe8.png">
