const createProxyMiddleware = require('http-proxy-middleware');
const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:62305';

const context =  [
    "/weatherforecast",
    "/categories",
    "/blogposts"
];

module.exports = function(app) {
  const appProxy = createProxyMiddleware(context, {
      target: "http://Phase3Section4a",
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  });

  app.use(appProxy);
};
