from bark import SAMPLE_RATE, generate_audio, preload_models
from scipy.io.wavfile import write as write_wav
from IPython.display import Audio

import torchaudio
torchaudio.set_audio_backend("soundfile")

# Download and load all models
preload_models()

# List of text prompts
prompts = [
    "Hello, my name is Smirch. And, uh — and I like pizza. [laughs]",
    "Second string",
    "aand here's the third one",
]

# Loop through each text prompt, generate audio, and save to a unique filename
for idx, text_prompt in enumerate(prompts, 1):
    audio_array = generate_audio(text_prompt, history_prompt="v2/en_speaker_2")
    filename = f"bark{idx}.wav"
    write_wav(filename, SAMPLE_RATE, audio_array)
    print(f"Saved: {filename}")