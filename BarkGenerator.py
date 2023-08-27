from bark import SAMPLE_RATE, generate_audio, preload_models
from scipy.io.wavfile import write as write_wav
from IPython.display import Audio

import torchaudio
torchaudio.set_audio_backend("soundfile")

# Download and load all models
preload_models()

# List of text prompts
prompts = [
    "Touchdown complete. Our L Z is only a few hundred yards from either point of interest.",
    "How often do we get to work on a planet that looks like this? This is the closest thing to a vacation that either of us have had in years.",
    "Look, I get it. This isn't a vacation. Avarice corp contracted us for a gig and we're going to complete it ASAP.",
]

# Loop through each text prompt, generate audio, and save to a unique filename
for idx, text_prompt in enumerate(prompts, 1):
    audio_array = generate_audio(text_prompt, history_prompt="v2/en_speaker_2")  #en_speaker_2 for Holden en_speaker_4 for Smirch
    filename = f"bark{idx}.wav"
    write_wav(filename, SAMPLE_RATE, audio_array)
    print(f"Saved: {filename}")