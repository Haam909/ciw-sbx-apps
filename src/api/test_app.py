from app import app


def test_health():
    response = app.test_client().get("/health")
    assert response.status_code == 200
    assert response.get_json() == {"status": "ok"}


def test_greet():
    response = app.test_client().get("/greet/ada")
    assert response.get_json() == {"message": "hello, ada"}
