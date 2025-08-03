<script>
    const { rev, play, pause, stop, ff } = $props();
</script>

<div class="transports-box">
    <button class="button" onpointerdown={() => rev()}>
        fast_rewind
    </button>
    <button class="button" onpointerdown={() => play()}>play_arrow</button>
    <button class="button" onpointerdown={() => pause()}>pause</button>
    <button class="button" onpointerdown={() => stop()}>stop</button>
    <button class="button" onpointerdown={() => ff()}>
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
