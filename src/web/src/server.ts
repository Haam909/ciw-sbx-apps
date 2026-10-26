import { createServer } from "node:http";
import { handle } from "./app.js";

const port = Number(process.env.PORT ?? 8080);
createServer(handle).listen(port, () => {
  console.log(`web listening on ${port}`);
});
