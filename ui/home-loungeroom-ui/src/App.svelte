<script lang="ts">
  import { onDestroy } from "svelte";
  import { useSerial, useAnalog, useDigital } from "ch5-svelte";
  import SystemOn from "./SystemOn.svelte";
  import Playground from "./Playground.svelte";
  import PowerButton from "./PowerButton.svelte";
  import {setEmulating, getEmulating} from "./GlobalState.svelte"
    import { fade, scale } from "svelte/transition";

  let powerOn = useDigital("10", "10");
  let powerOff = useDigital("11", "11");
  const showOn = useDigital("12");
  const showOff = useDigital("13");
</script>

<main>
{#if !showOn.value && !showOff.value} 
<!-- Disconnected -->
{#if getEmulating()}
<Playground />
{:else}
<p>Offline</p>
<button onclick={() => setEmulating(true)}>Enable Emulation</button>
{/if}

{:else}
<!-- Connected -->

  {#if showOn.value}
  <!-- Powered On -->
    <div style="position: absolute; z-index: 1000; top: 20px; right: 20px;" transition:fade>
        <PowerButton />
    </div>
    <div transition:fade>
        <SystemOn />
    </div>
  {:else}
  <!-- Powered Off -->
    <div class="power-off-box" transition:scale>
        <PowerButton />
        <p> System Off </p>
    </div>
  {/if}
{/if}
</main>

<style>
  main {
    width: 100%;
  }
      .power-off-box{
        position: absolute;
        transform: scale(400%, 400%) translate(145px, 80px);
        text-align: center;
    }
</style>
