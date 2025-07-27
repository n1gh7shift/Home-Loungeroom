<script lang="ts">
    import PowerButton from "./PowerButton.svelte";
    import {getPowerState} from "./GlobalState.svelte"
    import SystemOn from "./SystemOn.svelte";
    import { fade, scale } from "svelte/transition";
</script>

<div class="container">

    {#if getPowerState()}
    <div style="position: absolute; z-index: 1000; top: 20px; right: 20px;" transition:fade>
        <PowerButton />
    </div>
    <div transition:fade>
        <SystemOn />
    </div>
    {:else}
    <div class="power-off-box" transition:scale>
        <PowerButton />
        <p> System Off </p>
    </div>
    {/if}
</div>

<style>
    .power-off-box{
        position: absolute;
        transform: scale(400%, 400%) translate(145px, 80px);
        text-align: center;
    }
</style>