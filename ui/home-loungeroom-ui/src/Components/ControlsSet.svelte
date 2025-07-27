<script lang="ts">
    const { exit, menu, back, home } = $props();
</script>

<div class="buttons-box">
    <button class="button" onclick={() => exit()}
        >exit_to_app<span class="text">Exit</span></button
    >
    <button class="button" onclick={() => menu()}
        >menu<span class="text">Menu</span></button
    >
    <button class="button" onclick={() => back()}
        >arrow_back_ios_new<span class="text">Back</span></button
    >
    <button class="button" onclick={() => home()}
        >home<span class="text">Home</span></button
    >
</div>

<style>
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
    .buttons-box {
        font-size: xx-large;
        display: flex;
        flex-wrap: wrap;
        gap: 10px;
    }
    span.text {
        font-family: "Roboto", sans-serif;
    }
</style>
