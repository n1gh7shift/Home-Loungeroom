<script lang="ts">
    const { vol_up_start, vol_up_end, vol_down_start, vol_down_end } = $props();
</script>


<div class="volume-box">
    <button class="button" onpointerdown={() => vol_down_start()} onpointerup={() => vol_down_end()} onpointerleave={() => vol_down_end()}>volume_down</button>
    <button class="button" onpointerdown={() => vol_up_start()} onpointerup={() => vol_up_end()} onpointerleave={() => vol_up_end()}>volume_up</button>
</div>

<style>
    .volume-box {
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
        font-size: xx-large;
    }
</style>
