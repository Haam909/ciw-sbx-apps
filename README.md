# ciw-sbx-apps

Proof repo for [ci-workflows](https://github.com/Haam909/ci-workflows) `v2`:
apps and containers with no Azure.

| Component | Runtime | Target | Ships as |
|---|---|---|---|
| `web` | node (TypeScript) | `none` | zip on the GitHub Release |
| `api` | python (Flask) | `none` | zip on the GitHub Release |
| `worker` | python (Flask, gunicorn) | `container` | image on `ghcr.io/haam909/ciw-sbx-apps/worker` |
| `catalog` | dotnet (ASP.NET Core) | `none` | zip on the GitHub Release |
| `billing` | dotnet (ASP.NET Core) | `container` | image on `ghcr.io/haam909/ciw-sbx-apps/billing` |

The local gate needs Docker or Podman running, the .NET 10 SDK, and a
Python with the components' dependencies, `pytest` and `ruff`:

```bash
python -m venv .venv && source .venv/Scripts/activate   # .venv/bin/activate elsewhere
pip install --require-hashes -r src/worker/requirements.lock.txt
pip install pytest==9.0.2 ruff==0.15.21
(cd src/web && npm ci)
git config core.hooksPath .githooks
```
