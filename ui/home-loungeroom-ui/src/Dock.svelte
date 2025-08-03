<script lang="ts">
  import tvIcon from "./assets/tv_icon.svg";
  import psLogo from "./assets/PlayStation_logo.svg";
  import { getSelection, setSelection } from "./GlobalState.svelte";

  function handleSelectionPressed(pressed: number): void {
    setSelection(pressed);
  }
</script>

<div class="container">
  <button onpointerdown={() => handleSelectionPressed(1)}>
    <img
      src={psLogo}
      class="logo logo-ps"
      alt="Playstation Logo"
      style:transform={getSelection() === 1 ? "scale(2)" : "scale(1)"}
    />
  </button>
  <button onpointerdown={() => handleSelectionPressed(2)}>
    <img
      src={tvIcon}
      class="logo"
      alt="Svelte Logo"
      style:transform={getSelection() === 2 ? "scale(2)" : "scale(1)"}
    />
  </button>
</div>

<style>
  /* Add a smooth transition for the transform property */
  .logo {
    transition: transform 0.2s ease-in-out; /* Smooth transition for scale */
  }

  .container {
    margin-top: 20px;
    border-radius: 24px;
    padding: 0 12px;
    background-image: linear-gradient(
      to bottom,
      rgba(255, 255, 255, 0),
      rgba(255, 255, 255, 0.15)
    );
    box-shadow: rgba(255, 255, 255, 0.17) 0px 0px 0px 1px inset;

    display: flex;
  }

  .container button {
    background: transparent; /* Ensure buttons don't have default background */
    border: none; /* Remove button borders */
    padding: 0; /* Remove button padding */
    cursor: pointer; /* Indicate it's clickable */
  }

  .container img {
    margin: 20px 25px;
    width: 50px;
    height: 50px;
    display: block;
  }

  .logo-ps {
    filter: brightness(0) saturate(100%) invert(74%) sepia(97%) saturate(1%)
      hue-rotate(45deg) brightness(103%) contrast(97%);
  }
</style>
