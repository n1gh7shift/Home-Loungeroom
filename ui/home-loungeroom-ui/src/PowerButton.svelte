<script lang="ts">
  import { useDigital } from "ch5-svelte";
  import power from "./assets/power.svg";
  import {
    setPowerState,
    getPowerState,
    getEmulating,
  } from "./GlobalState.svelte";

  const onButton = useDigital("10", "10");
  const offButton = useDigital("11", "11");
  const processorOnState = useDigital("12");

  function handlePowerButton() {
    if (getEmulating()) {
      setPowerState(!getPowerState());
      console.log("[IsEmulating] Power state = ", getPowerState);
    } else {
      console.log("IsNotEmulating");
      if (processorOnState.value) {
        offButton.pulse();
      } else {
        onButton.pulse();
      }
    }
  }
</script>

  <button class="powerbutton" onpointerdown={() => handlePowerButton()}>
    <!-- <img src={power} alt="power icon" /></button> -->

    power_settings_new
  </button>


<style>
  .powerbutton {
    font-family: "Material Icons";
    font-size: xx-large;
    line-height: 0px;
    text-align: center;
    vertical-align: middle;
    box-sizing: content-box;
    min-width: 72px;
    min-height: 72px;
  }
</style>
