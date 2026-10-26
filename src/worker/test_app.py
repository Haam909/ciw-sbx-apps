from app import app


def test_healthz(monkeypatch):
    monkeypatch.setenv("APP_VERSION", "1.2.3")
    response = app.test_client().get("/healthz")
    assert response.status_code == 200
    assert response.get_json() == {"status": "ok", "version": "1.2.3"}
