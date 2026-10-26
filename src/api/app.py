from flask import Flask, jsonify

app = Flask(__name__)


@app.get("/health")
def health():
    return jsonify(status="ok")


@app.get("/greet/<name>")
def greet(name: str):
    return jsonify(message=f"hello, {name}")
