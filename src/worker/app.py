import os

from flask import Flask, jsonify

app = Flask(__name__)


@app.get("/healthz")
def healthz():
    return jsonify(status="ok", version=os.environ.get("APP_VERSION", "dev"))
