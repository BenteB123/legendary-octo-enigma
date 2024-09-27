# legendary-octo-enigma

## How to Start the apitest Project

1. Open a terminal and navigate to the project folder:
	```sh
	cd apitest
	```

2. Restore the project dependencies:
	```sh
	dotnet restore
	```

3. Update the database using Entity Framework migrations:
	```sh
	dotnet ef database update
	```

4. Run the project:
	```sh
	dotnet run
	```

5. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## How to Start the reacttest Project

1. Open a terminal and navigate to the project folder:
	```sh
	cd reacttest
	```

2. Install the project dependencies:
	```sh
	npm install
	```

3. Start the development server:
	```sh
	npm start
	```

4. The React application will be available at `http://localhost:3000`.

