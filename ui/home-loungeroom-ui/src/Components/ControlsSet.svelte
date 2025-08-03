<script lang="ts">
    const { exit, menu, back, home } = $props();
</script>

<div class="buttons-box">
    <button class="button" onpointerdown={() => back()}
        >arrow_back_ios_new<span class="text">Back</span></button
    >
    <button class="button" onpointerdown={() => menu()}
        >menu<span class="text">Menu</span></button
    >
    <button class="button" onpointerdown={() => exit()}
        >exit_to_app<span class="text">Exit</span></button
    >
    <button class="button" onpointerdown={() => home()}
        >home<span class="text">Home</span></button
    >
</div>

<style>
    .button {
        font-family: "Material Icons";
        background: #f5f5fa;
        border: 0;
        border-radius: 8px;
        color: #2a1f62;
        /* touch-action: manipulation; */
        min-height: 72px;
        min-width: 72px;
        font-size: large;
    }
    .buttons-box {
        font-size: xx-large;
        gap: 10px;
    }
    span.text {
        font-family: "Roboto", sans-serif;
        text-align: center;
        vertical-align: bottom;
    }
</style>
