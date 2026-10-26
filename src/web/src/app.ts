import type { IncomingMessage, ServerResponse } from "node:http";
import ms from "ms";

const started = Date.now();

export function handle(req: IncomingMessage, res: ServerResponse): void {
  if (req.url === "/health") {
    res.writeHead(200, { "content-type": "application/json" });
    res.end(JSON.stringify({ status: "ok", uptime: ms(Date.now() - started) }));
    return;
  }
  res.writeHead(404, { "content-type": "text/plain" });
  res.end("not found");
}
