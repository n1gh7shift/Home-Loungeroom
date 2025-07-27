<script>
    const { rev, play, pause, stop, ff } = $props();

    // rev = handleRev
    // play = handlePlay
    // pause = handlePause
    // stop = handleStop
    // ff = handleFf
    // <TransportsSet rev={handleRev} play={handlePlay} pause={handlePause} stop={handleStop} ff={handleFf}/>

    // function handleRev() {}
    // function handlePlay() {}
    // function handlePause() {}
    // function handleStop() {}
    // function handleFf() {}

</script>

<div class="transports-box">
    <button class="button" onclick={() => rev()}>
        fast_rewind
    </button>
    <button class="button" onclick={() => play()}>play_arrow</button>
    <button class="button" onclick={() => pause()}>pause</button>
    <button class="button" onclick={() => stop()}>stop</button>
    <button class="button" onclick={() => ff()}>
        fast_forward
    </button>
</div>

<style>
    .transports-box {
        display: flex;
        align-items: center;
        gap: 10px;
    }

        .button {
        font-family: "Material Icons";
        align-items: center;
        background: #f5f5fa;
        border: 0;
        border-radius: 8px;
        box-sizing: border-box;
        color: #2a1f62;
        cursor: pointer;
        display: flex;
        justify-content: center;
        line-height: 1.5rem;
        position: relative;
        text-align: left;
        transition: 0.2s;
        user-select: none;
        -webkit-user-select: none;
        touch-action: manipulation;
        white-space: pre;
        width: max-content;
        word-break: normal;
        word-spacing: normal;
        min-height: 72px;
        min-width: 72px;
        font-size: large;
    }
</style>
