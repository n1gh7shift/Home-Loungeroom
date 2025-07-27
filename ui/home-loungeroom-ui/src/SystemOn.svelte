<script lang="ts">
    import Dock from "./Dock.svelte";
    import Playstation from "./Playstation.svelte";
    import Tv from "./TVControls.svelte";
    import { fly } from "svelte/transition";
    import { getSelection } from "./GlobalState.svelte";
</script>

<div class="container">
    <div class="top-bar">
        <Dock />
    </div>
    <div class="content">
        {#if getSelection() === 1}
        <div style="position: absolute;" transition:fly={{ x: -600, duration: 2000 }}>
            <Playstation />
        </div>
        {:else if getSelection() === 2}
        <div style="position: absolute;" transition:fly={{ x: 600, duration: 2000 }}>
            <Tv />
        </div>
        {:else}{/if}
    </div>
</div>

<style>
    .container {
        width: 100%;
        height: 100%;
        position: absolute;
        top: 0;
        left: 0;
    }

    .top-bar{
        display:flex;
        justify-content: center;
    }
    .content{
        display: flex;
        justify-content: center;
        position: relative;
    }
</style>
