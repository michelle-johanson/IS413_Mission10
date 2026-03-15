# Setup React App

1. Open the project folder

2. Create Vite: `npm create vite@latest frontend`
   - Framework: React
   - Variant: TypeScript
   - Install with npm and start now
     - `cd frontend`
     - `npm install`
     - `npm run dev`

3. Install Prettier: `npm install prettier --save-dev`
   - Check that VSCode extention is installed

4. Configure Prettier:
   - Create `.prettierrc.json`

   ```json
   {
     "semi": true,
     "singleQuote": true,
     "jsxSingleQuote": false,
     "trailingComma": "es5",
     "printWidth": 80,
     "tabWidth": 2,
     "endOfLine": "auto"
   }
   ```

   - Update `eslint.config.js`

   ```js
   import js from "@eslint/js";
   import globals from "globals";
   import reactHooks from "eslint-plugin-react-hooks";
   import reactRefresh from "eslint-plugin-react-refresh";
   import tseslint from "typescript-eslint";
   import { defineConfig, globalIgnores } from "eslint/config";
   import eslintConfigPrettier from "eslint-config-prettier";

   export default defineConfig([
     globalIgnores(["dist"]),
     {
       files: ["**/*.{ts,tsx}"],
       extends: [
         js.configs.recommended,
         tseslint.configs.recommended,
         reactHooks.configs.flat.recommended,
         reactRefresh.configs.vite,
         eslintConfigPrettier,
       ],
       languageOptions: {
         ecmaVersion: 2020,
         globals: globals.browser,
       },
     },
   ]);
   ```

   - Run: `npm install --save-dev eslint prettier eslint-config-prettier eslint-plugin-prettier`

## Publish to GitHub

1. Initialize the repo locally:
   - `git init`
   - `git add .`
   - `git commit -m "Initial commit"`
2. Create a new repo on GitHub:
   - Go to github.com → New repository
   - Name it whatever you want (doesn't have to match your local folder name)
   - Leave it empty (no README, .gitignore, or license)
3. Connect and push:
   - `git remote add origin https://github.com/your-username/your-repo-name.git`
   - `git branch -M main`
   - `git push -u origin main`

## Starter Files

### `src/App.jsx`

```jsx
import "./App.css";

function App() {
  return (
    <>
      <h1>Hello World</h1>
    </>
  );
}

export default App;
```

### `src/App.css`

```css
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
```

### `src/index.css`

```css
:root {
  --sans: system-ui, "Segoe UI", Roboto, sans-serif;
  font: 18px/145% var(--sans);
  -webkit-font-smoothing: antialiased;
}

#root {
  max-width: 1400px;
  margin: 0 auto;
  min-height: 100vh;
  box-sizing: border-box;
}
```
