FROM node:18-alpine
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
# Run in watch mode for development
CMD ["npm", "run", "dev"]