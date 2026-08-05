using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using POpusCodec;
using POpusCodec.Enums;
using SA.Foundation.PropertyDrawers.Attributes;
using SA.Foundation.Templates;
using SA.Foundation.Tests;
using SA.iOS.Contacts;
using SA.iOS.CoreLocation;
using SA.iOS.Foundation;
using SA.iOS.GameKit;
using SA.iOS.MediaPlayer;
using SA.iOS.ReplayKit;
using SA.iOS.StoreKit;
using SA.iOS.UIKit;
using SA.iOS.UserNotifications;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class DataCallback : AndroidJavaProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private Action<short[]> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private IntPtr javaBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private int cntFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private int cntShort;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x12FFC20", Offset = "0x12FE220", VA = "0x1812FFC20")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x12FFBA0", Offset = "0x12FE1A0", VA = "0x1812FFBA0")]
		public void OnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x12FFC10", Offset = "0x12FE210", VA = "0x1812FFC10")]
		public void OnStop()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private AndroidJavaObject audioIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IntPtr javaBuf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DataCallback callback;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x31B410", Offset = "0x319A10", VA = "0x18031B410", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x12FD1D0", Offset = "0x12FB7D0", VA = "0x1812FD1D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
	public AndroidAudioInAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x12FC700", Offset = "0x12FAD00", VA = "0x1812FC700", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12FC6A0", Offset = "0x12FACA0", VA = "0x1812FC6A0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private AudioClip audioClip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private int readPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float startTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool playing;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool Loop
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x30C4C0", Offset = "0x30AAC0", VA = "0x18030C4C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x30C610", Offset = "0x30AC10", VA = "0x18030C610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10A2EA0", Offset = "0x10A14A0", VA = "0x1810A2EA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x10A2E80", Offset = "0x10A1480", VA = "0x1810A2E80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x12FD310", Offset = "0x12FB910", VA = "0x1812FD310")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x12FD1E0", Offset = "0x12FB7E0", VA = "0x1812FD1E0", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AudioOutCapture : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12FDCE0", Offset = "0x12FC2E0", VA = "0x1812FDCE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12FDD80", Offset = "0x12FC380", VA = "0x1812FDD80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x12FDC80", Offset = "0x12FC280", VA = "0x1812FDC80")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public AudioOutCapture()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AudioStreamPlayer : IAudioOut
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int maxPlayLagMs = 100;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private int maxPlayLagSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int playDelaySamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int bufferSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int channels;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int frameSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int frameSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int streamSamplePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int streamSamplePosAvg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AudioSource source;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private string logPrefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool debugInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int sourceTimeSamplesPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int playLoopCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Queue<float[]> frameQueue;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PrimitiveArrayPool<float> framePool;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CurrentBufferLag
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x301860", Offset = "0x2FFE60", VA = "0x180301860", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3019A0", Offset = "0x2FFFA0", VA = "0x1803019A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AudioSource AudioSource
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2E98B0", Offset = "0x2E7EB0", VA = "0x1802E98B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int playSamplePos
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x12FED30", Offset = "0x12FD330", VA = "0x1812FED30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x12FEDF0", Offset = "0x12FD3F0", VA = "0x1812FEDF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12FED10", Offset = "0x12FD310", VA = "0x1812FED10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x12FEC40", Offset = "0x12FD240", VA = "0x1812FEC40")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x12FEA90", Offset = "0x12FD090", VA = "0x1812FEA90", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x12FE180", Offset = "0x12FC780", VA = "0x1812FE180", Slot = "8")]
	public void Service()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x12FDE20", Offset = "0x12FC420", VA = "0x1812FDE20", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x12FEC00", Offset = "0x12FD200", VA = "0x1812FEC00", Slot = "6")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x12FE100", Offset = "0x12FC700", VA = "0x1812FE100", Slot = "10")]
	public void Pause()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0")]
	private void PhotonVoiceCreated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private AudioClip mic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private string device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private int micPrevPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int micLoopCnt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int readAbsPos;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10A2EA0", Offset = "0x10A14A0", VA = "0x1810A2EA0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x10A2E80", Offset = "0x10A1480", VA = "0x1810A2E80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x10A2DD0", Offset = "0x10A13D0", VA = "0x1810A2DD0")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x10A2CB0", Offset = "0x10A12B0", VA = "0x1810A2CB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x10A2CC0", Offset = "0x10A12C0", VA = "0x1810A2CC0", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class WindowsAudioInPusher : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private enum SystemMode
	{
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		SINGLE_CHANNEL_AEC = 0,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		OPTIBEAM_ARRAY_ONLY = 2,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		OPTIBEAM_ARRAY_AND_AEC = 4,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		SINGLE_CHANNEL_NSAGC = 5
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IntPtr handle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Action<short[]> pushCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private LocalVoiceFramed<short> localVoice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int deviceID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Action<IntPtr, int> pushRef;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x31B410", Offset = "0x319A10", VA = "0x18031B410", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1E86400", Offset = "0x1E84A00", VA = "0x181E86400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E85FD0", Offset = "0x1E845D0", VA = "0x181E85FD0")]
	private static extern IntPtr Photon_Audio_In_Create(SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E860E0", Offset = "0x1E846E0", VA = "0x181E860E0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E863D0", Offset = "0x1E849D0", VA = "0x181E863D0")]
	public WindowsAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1E86180", Offset = "0x1E84780", VA = "0x181E86180", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E86410", Offset = "0x1E84A10", VA = "0x181E86410")]
	private void push(IntPtr buf, int lenBytes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E85F30", Offset = "0x1E84530", VA = "0x181E85F30", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class SA_PD_EditorIcons
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E84F30", Offset = "0x1E83530", VA = "0x181E84F30")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Error
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x109A6C0", Offset = "0x1098CC0", VA = "0x18109A6C0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x109AE50", Offset = "0x1099450", VA = "0x18109AE50", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x109B050", Offset = "0x1099650", VA = "0x18109B050", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x109AED0", Offset = "0x10994D0", VA = "0x18109AED0", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x109AF40", Offset = "0x1099540", VA = "0x18109AF40", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x109AFB0", Offset = "0x10995B0", VA = "0x18109AFB0", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x109B000", Offset = "0x1099600", VA = "0x18109B000", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x109B4A0", Offset = "0x1099AA0", VA = "0x18109B4A0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
	public ISN_CoreLocationDelegateExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ISN_CoreLocationUseExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	private Button m_AuthButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	private Button m_StartUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	private Button m_StopUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	private Button m_RequestLocationButton;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x109B760", Offset = "0x1099D60", VA = "0x18109B760")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x109B600", Offset = "0x1099C00", VA = "0x18109B600")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_CoreLocationUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x12FFDC0", Offset = "0x12FE3C0", VA = "0x1812FFDC0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public DocumentationExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ISN_MediaPlayerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[SerializeField]
	[Header("Info Panel")]
	private Text m_title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	private Text m_artist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[SerializeField]
	private Text m_playbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	[Header("Buttons")]
	private Button m_play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	private Button m_stop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[SerializeField]
	private Button m_pause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[SerializeField]
	private Button m_next;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[SerializeField]
	private Button m_previos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private ISN_MPMusicPlayerController m_player;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x109C9D0", Offset = "0x109AFD0", VA = "0x18109C9D0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x109CD60", Offset = "0x109B360", VA = "0x18109CD60")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_MediaPlayerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ISN_CameraGalleryExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[SerializeField]
	private Button m_loadFromGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[SerializeField]
	private Button m_loadFromCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[SerializeField]
	private Button m_saveToGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[SerializeField]
	private Image m_image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[SerializeField]
	private GameObject m_go;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x109A9A0", Offset = "0x1098FA0", VA = "0x18109A9A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_CameraGalleryExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ISN_SocialExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[SerializeField]
	private Button m_twitterText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[SerializeField]
	private Button m_twitterTextImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[SerializeField]
	private Button m_fbImage;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x109DEF0", Offset = "0x109C4F0", VA = "0x18109DEF0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_SocialExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ISN_UIImagePickerControllerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[SerializeField]
	private RawImage m_Image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[SerializeField]
	private Image m_Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[SerializeField]
	[Header("Image")]
	private Button m_ImageCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[SerializeField]
	private Button m_ImageLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[SerializeField]
	private Button m_ImageAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[SerializeField]
	[Header("Video")]
	private Button m_VideoCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[SerializeField]
	private Button m_VideoLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[SerializeField]
	private Button m_VideoAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[SerializeField]
	private Button m_VideoPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private ISN_UIPickerControllerResult m_LastPickerResult;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x109EC40", Offset = "0x109D240", VA = "0x18109EC40")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x109EAB0", Offset = "0x109D0B0", VA = "0x18109EAB0")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x109F660", Offset = "0x109DC60", VA = "0x18109F660")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x109F290", Offset = "0x109D890", VA = "0x18109F290")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x109F0E0", Offset = "0x109D6E0", VA = "0x18109F0E0")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x109EB20", Offset = "0x109D120", VA = "0x18109EB20")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x109EFC0", Offset = "0x109D5C0", VA = "0x18109EFC0")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
namespace SA.iOS.Tests.UserNotifications
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ISN_RemoteNotifications_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E83B20", Offset = "0x1E82120", VA = "0x181E83B20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E84730", Offset = "0x1E82D30", VA = "0x181E84730", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_UNAuthorization_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ISN_UNSchedule_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E84810", Offset = "0x1E82E10", VA = "0x181E84810", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E84BC0", Offset = "0x1E831C0", VA = "0x181E84BC0")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_UNSchedule_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.UIKit
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ISN_UIImagePickerController_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E842A0", Offset = "0x1E828A0", VA = "0x181E842A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E84170", Offset = "0x1E82770", VA = "0x181E84170")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E857A0", Offset = "0x1E83DA0", VA = "0x181E857A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public SaveToCameraRollTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_DefaultSharingDialog_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1E82080", Offset = "0x1E80680", VA = "0x181E82080", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E82350", Offset = "0x1E80950", VA = "0x181E82350", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E83860", Offset = "0x1E81E60", VA = "0x181E83860", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E83970", Offset = "0x1E81F70", VA = "0x181E83970", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E83D20", Offset = "0x1E82320", VA = "0x181E83D20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E84060", Offset = "0x1E82660", VA = "0x181E84060", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E84DD0", Offset = "0x1E833D0", VA = "0x181E84DD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_WhatsAppShare_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.GameKit
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_GKAchievementsLoad_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E82470", Offset = "0x1E80A70", VA = "0x181E82470", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1E828A0", Offset = "0x1E80EA0", VA = "0x181E828A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1E827C0", Offset = "0x1E80DC0", VA = "0x181E827C0")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E82750", Offset = "0x1E80D50", VA = "0x181E82750")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E82B60", Offset = "0x1E81160", VA = "0x181E82B60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E82AF0", Offset = "0x1E810F0", VA = "0x181E82AF0")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E82D20", Offset = "0x1E81320", VA = "0x181E82D20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E82D50", Offset = "0x1E81350", VA = "0x181E82D50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E82F60", Offset = "0x1E81560", VA = "0x181E82F60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E831E0", Offset = "0x1E817E0", VA = "0x181E831E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E83400", Offset = "0x1E81A00", VA = "0x181E83400", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E835B0", Offset = "0x1E81BB0", VA = "0x181E835B0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E83710", Offset = "0x1E81D10", VA = "0x181E83710", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		protected ISN_GKSingleLeaderboard_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_AudioSessionTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1E81890", Offset = "0x1E7FE90", VA = "0x181E81890", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1E81900", Offset = "0x1E7FF00", VA = "0x181E81900", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E84E70", Offset = "0x1E83470", VA = "0x181E84E70", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E83AA0", Offset = "0x1E820A0", VA = "0x181E83AA0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E83E40", Offset = "0x1E82440", VA = "0x181E83E40", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_TimeZoneTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Contacts
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_CNContactsPicker_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E819B0", Offset = "0x1E7FFB0", VA = "0x181E819B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E81F50", Offset = "0x1E80550", VA = "0x181E81F50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E81A80", Offset = "0x1E80080", VA = "0x181E81A80")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E818F0", Offset = "0x1E7FEF0", VA = "0x181E818F0")]
		public ISN_CNFetchPhoneContacts_Test()
		{
		}
	}
}
namespace SA.iOS.Examples
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AVKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1097E90", Offset = "0x1096490", VA = "0x181097E90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
		public AVKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ISN_BaseIOSFeaturePreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected GUIStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected int buttonWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected int buttonHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected float StartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected float StartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected float XStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected float YStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		protected float XButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		protected float YButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		protected float YLableStep;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x109A840", Offset = "0x1098E40", VA = "0x18109A840", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x96DE00", Offset = "0x96C400", VA = "0x18096DE00", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x109A940", Offset = "0x1098F40", VA = "0x18109A940")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x109A930", Offset = "0x1098F30", VA = "0x18109A930")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x109A950", Offset = "0x1098F50", VA = "0x18109A950")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x109BCC0", Offset = "0x109A2C0", VA = "0x18109BCC0")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public ISN_FoundationExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class GameKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private List<ISN_GKSavedGame> m_fetchedSavedGames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private List<string> m_conflictedSavedGames;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x10981F0", Offset = "0x10967F0", VA = "0x1810981F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1098B20", Offset = "0x1097120", VA = "0x181098B20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10982D0", Offset = "0x10968D0", VA = "0x1810982D0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1098600", Offset = "0x1096C00", VA = "0x181098600")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1098C00", Offset = "0x1097200", VA = "0x181098C00")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x109A640", Offset = "0x1098C40", VA = "0x18109A640")]
		public GameKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class iCloudUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private float valueF;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1E86560", Offset = "0x1E84B60", VA = "0x181E86560")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1E86650", Offset = "0x1E84C50", VA = "0x181E86650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E87040", Offset = "0x1E85640", VA = "0x181E87040")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E866E0", Offset = "0x1E84CE0", VA = "0x181E866E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1E872C0", Offset = "0x1E858C0", VA = "0x181E872C0")]
		public iCloudUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ISN_UIController : SA_UIController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ScrollRect scroll;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x109E240", Offset = "0x109C840", VA = "0x18109E240", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x109E740", Offset = "0x109CD40", VA = "0x18109E740")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x109E4D0", Offset = "0x109CAD0", VA = "0x18109E4D0", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x109E720", Offset = "0x109CD20", VA = "0x18109E720", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x109E9D0", Offset = "0x109CFD0", VA = "0x18109E9D0", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x109E660", Offset = "0x109CC60", VA = "0x18109E660", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x109E920", Offset = "0x109CF20", VA = "0x18109E920", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x109E190", Offset = "0x109C790", VA = "0x18109E190", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x36A6D0", Offset = "0x368CD0", VA = "0x18036A6D0")]
		public ISN_UIController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class SA_ExampleSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public List<SA_ExampleServicesConfig> Services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Sprite Logo;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x10A4AC0", Offset = "0x10A30C0", VA = "0x1810A4AC0")]
		public SA_ExampleSceneConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class SA_ExampleSceneController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private SA_ExampleSceneConfig m_config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private SA_UIController m_UIController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private List<GameObject> m_links;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x10A51A0", Offset = "0x10A37A0", VA = "0x1810A51A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x10A5340", Offset = "0x10A3940", VA = "0x1810A5340")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x10A5160", Offset = "0x10A3760", VA = "0x1810A5160")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x10A4B50", Offset = "0x10A3150", VA = "0x1810A4B50")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x10A4E60", Offset = "0x10A3460", VA = "0x1810A4E60")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x10A4D20", Offset = "0x10A3320", VA = "0x1810A4D20")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x10A4F10", Offset = "0x10A3510", VA = "0x1810A4F10")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x10A54B0", Offset = "0x10A3AB0", VA = "0x1810A54B0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x10A5010", Offset = "0x10A3610", VA = "0x1810A5010")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x10A4B20", Offset = "0x10A3120", VA = "0x1810A4B20")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x10A5520", Offset = "0x10A3B20", VA = "0x1810A5520")]
		public SA_ExampleSceneController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class SA_ExampleServicesConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Sprite Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public List<SA_ExampleSubsectionConfig> Subsections;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x10A5580", Offset = "0x10A3B80", VA = "0x1810A5580")]
		public SA_ExampleServicesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class SA_ExampleSubsectionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public SA_SceneField Scene;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public SA_ExampleSubsectionConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class SA_SceneField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private UnityEngine.Object sceneAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private string sceneName;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x10A58C0", Offset = "0x10A3EC0", VA = "0x1810A58C0")]
		public SA_SceneField()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class SA_SideToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[HideInInspector]
		public Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x10A5A30", Offset = "0x10A4030", VA = "0x1810A5A30")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x10A5900", Offset = "0x10A3F00", VA = "0x1810A5900", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x10A5940", Offset = "0x10A3F40", VA = "0x1810A5940", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x10A5B40", Offset = "0x10A4140", VA = "0x1810A5B40")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x10A59B0", Offset = "0x10A3FB0", VA = "0x1810A59B0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
		public SA_SideToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SA_TopToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private Text m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Image m_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E855B0", Offset = "0x1E83BB0", VA = "0x181E855B0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1E85440", Offset = "0x1E83A40", VA = "0x181E85440", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E85480", Offset = "0x1E83A80", VA = "0x181E85480", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E85710", Offset = "0x1E83D10", VA = "0x181E85710")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E854C0", Offset = "0x1E83AC0", VA = "0x181E854C0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
		public SA_TopToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class SA_UIController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Action<int> OnTopMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Action<string> OnSideMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		protected Image m_logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		protected GameObject m_topMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		protected GameObject m_sideMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		protected GameObject m_sideScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		protected GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		protected Text m_logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected GameObject m_prevSideItem;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SetLogo(Sprite sprite);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ShowTopMenuItem(GameObject menuItem);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void UnloadContent();

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LoadContent(GameObject canvas);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AddLog(string log);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
		protected SA_UIController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_ReplayKitUseExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool IsRecording;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x109D910", Offset = "0x109BF10", VA = "0x18109D910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x109DB30", Offset = "0x109C130", VA = "0x18109DB30")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x109DD90", Offset = "0x109C390", VA = "0x18109DD90")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x109A950", Offset = "0x1098F50", VA = "0x18109A950")]
		public ISN_ReplayKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class ISN_MarketExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static ISN_PaymentManagerExample s_paymentManager;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x109BDF0", Offset = "0x109A3F0", VA = "0x18109BDF0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x109A950", Offset = "0x1098F50", VA = "0x18109A950")]
		public ISN_MarketExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class ISN_PaymentManagerExample : ISN_iSKPaymentTransactionObserver
	{
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public const string SMALL_PACK = "buying_10000";

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public const string NC_PACK = "mm_subscription";

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static bool IsInitialized;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x109D760", Offset = "0x109BD60", VA = "0x18109D760")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x109D6C0", Offset = "0x109BCC0", VA = "0x18109D6C0")]
		private static void UnlockProducts(ISN_SKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x109D190", Offset = "0x109B790", VA = "0x18109D190", Slot = "4")]
		public void OnTransactionUpdated(ISN_SKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
		public void OnTransactionRemoved(ISN_SKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3B7740", Offset = "0x3B5D40", VA = "0x1803B7740", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x109CEE0", Offset = "0x109B4E0", VA = "0x18109CEE0", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public ISN_PaymentManagerExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class ISN_UIKitExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private Texture2D m_icon;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x109F6F0", Offset = "0x109DCF0", VA = "0x18109F6F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x109F870", Offset = "0x109DE70", VA = "0x18109F870")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x109A950", Offset = "0x1098F50", VA = "0x18109A950")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x10A0FA0", Offset = "0x109F5A0", VA = "0x1810A0FA0")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x10A0810", Offset = "0x109EE10", VA = "0x1810A0810")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x10A0C00", Offset = "0x109F200", VA = "0x1810A0C00")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x10A0A40", Offset = "0x109F040", VA = "0x1810A0A40")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x10A0D90", Offset = "0x109F390", VA = "0x1810A0D90")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x10A08E0", Offset = "0x109EEE0", VA = "0x1810A08E0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x33AD70", Offset = "0x339370", VA = "0x18033AD70")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x10A1160", Offset = "0x109F760", VA = "0x1810A1160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x10A2980", Offset = "0x10A0F80", VA = "0x1810A2980")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x10A1C90", Offset = "0x10A0290", VA = "0x1810A1C90")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x10A1E70", Offset = "0x10A0470", VA = "0x1810A1E70")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x10A1910", Offset = "0x109FF10", VA = "0x1810A1910")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x10A1440", Offset = "0x109FA40", VA = "0x1810A1440")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x109A950", Offset = "0x1098F50", VA = "0x18109A950")]
		public ISN_UserNotificationsExamples()
		{
		}
	}
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Space]
		[Space]
		[SA_PD_ThingInsertionDecorator]
		[SA_PD_PRInsertionDecorator]
		[SA_PD_StandartInsertionDecorator]
		[Space]
		[Space]
		[Header("Help Boxes Decorators")]
		[Space(10f)]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.Info, "Pre-defined text")]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.None, "")]
		[Header("Insertions")]
		[Space(10f)]
		[Header("Headers")]
		[Space(10f)]
		[SA_PD_HeaderDecorator("Indent Header")]
		[Header("Indent level")]
		[Space(10f)]
		[SA_PD_IndentLevel(1)]
		public string indentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x10A4A30", Offset = "0x10A3030", VA = "0x1810A4A30")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2EA6B0", Offset = "0x2E8CB0", VA = "0x1802EA6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x10A55E0", Offset = "0x10A3BE0", VA = "0x1810A55E0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x10A5640", Offset = "0x10A3C40", VA = "0x1810A5640")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x10A56B0", Offset = "0x10A3CB0", VA = "0x1810A56B0")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x10A56B0", Offset = "0x10A3CB0", VA = "0x1810A56B0")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x10A5720", Offset = "0x10A3D20", VA = "0x1810A5720")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x10A5790", Offset = "0x10A3D90", VA = "0x1810A5790")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6D51B0", Offset = "0x6D37B0", VA = "0x1806D51B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6D51C0", Offset = "0x6D37C0", VA = "0x1806D51C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x783620", Offset = "0x781C20", VA = "0x180783620")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x10A5830", Offset = "0x10A3E30", VA = "0x1810A5830")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6D51B0", Offset = "0x6D37B0", VA = "0x1806D51B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x6D51C0", Offset = "0x6D37C0", VA = "0x1806D51C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x783620", Offset = "0x781C20", VA = "0x180783620")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x10A5830", Offset = "0x10A3E30", VA = "0x1810A5830")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x682EB0", Offset = "0x6814B0", VA = "0x180682EB0")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x10A56E0", Offset = "0x10A3CE0", VA = "0x1810A56E0")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4B1430", Offset = "0x4AFA30", VA = "0x1804B1430")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4B1430", Offset = "0x4AFA30", VA = "0x1804B1430")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4B1430", Offset = "0x4AFA30", VA = "0x1804B1430")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace POpusCodec
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class OpusDecoder : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private const int MaxFrameSize = 5760;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool _previousPacketInvalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int _channelCount;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly float[] EmptyBufferFloat;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly short[] EmptyBufferShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private Bandwidth? _previousPacketBandwidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float[] bufferFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private short[] bufferShort;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public SamplingRate SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4720D0", Offset = "0x4706D0", VA = "0x1804720D0")]
			[CompilerGenerated]
			get
			{
				return default(SamplingRate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAB0", Offset = "0x2EA0B0", VA = "0x1802EBAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Channels Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3035A0", Offset = "0x301BA0", VA = "0x1803035A0")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x10A3430", Offset = "0x10A1A30", VA = "0x1810A3430")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x10A2EC0", Offset = "0x10A14C0", VA = "0x1810A2EC0")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x10A30F0", Offset = "0x10A16F0", VA = "0x1810A30F0")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x10A3320", Offset = "0x10A1920", VA = "0x1810A3320", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class OpusEncoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public const int BitrateMax = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private const int RecommendedMaxPacketSize = 4000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int _frameSizePerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private SamplingRate _inputSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private Channels _inputChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private readonly byte[] writePacket;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private Delay _encoderDelay;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public SamplingRate InputSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x3035A0", Offset = "0x301BA0", VA = "0x1803035A0")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Channels InputChannels
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3017E0", Offset = "0x2FFDE0", VA = "0x1803017E0")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Delay EncoderDelay
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x31B320", Offset = "0x319920", VA = "0x18031B320")]
			get
			{
				return default(Delay);
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x10A4100", Offset = "0x10A2700", VA = "0x1810A4100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int FrameSizePerChannel
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x2F4B50", Offset = "0x2F3150", VA = "0x1802F4B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x10A3F80", Offset = "0x10A2580", VA = "0x1810A3F80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x10A40A0", Offset = "0x10A26A0", VA = "0x1810A40A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Bandwidth MaxBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x10A4020", Offset = "0x10A2620", VA = "0x1810A4020")]
			get
			{
				return default(Bandwidth);
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x10A4260", Offset = "0x10A2860", VA = "0x1810A4260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x10A3FA0", Offset = "0x10A25A0", VA = "0x1810A3FA0")]
			get
			{
				return default(Complexity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x10A40C0", Offset = "0x10A26C0", VA = "0x1810A40C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int ExpectedPacketLossPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x10A3FE0", Offset = "0x10A25E0", VA = "0x1810A3FE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x10A4220", Offset = "0x10A2820", VA = "0x1810A4220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public SignalHint SignalHint
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x10A4040", Offset = "0x10A2640", VA = "0x1810A4040")]
			get
			{
				return default(SignalHint);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x10A4280", Offset = "0x10A2880", VA = "0x1810A4280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ForceChannels ForceChannels
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x10A4000", Offset = "0x10A2600", VA = "0x1810A4000")]
			get
			{
				return default(ForceChannels);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x10A4240", Offset = "0x10A2840", VA = "0x1810A4240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UseInbandFEC
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x10A4060", Offset = "0x10A2660", VA = "0x1810A4060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x10A42A0", Offset = "0x10A28A0", VA = "0x1810A42A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool UseUnconstrainedVBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x10A4080", Offset = "0x10A2680", VA = "0x1810A4080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x10A42C0", Offset = "0x10A28C0", VA = "0x1810A42C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DtxEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x10A3FC0", Offset = "0x10A25C0", VA = "0x1810A3FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x10A40E0", Offset = "0x10A26E0", VA = "0x1810A40E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x10A3B40", Offset = "0x10A2140", VA = "0x1810A3B40")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x10A36B0", Offset = "0x10A1CB0", VA = "0x1810A36B0")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x10A38C0", Offset = "0x10A1EC0", VA = "0x1810A38C0")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x10A3610", Offset = "0x10A1C10", VA = "0x1810A3610", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class OpusException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private OpusStatusCode _statusCode;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public OpusStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4861D0", Offset = "0x4847D0", VA = "0x1804861D0")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x10A42E0", Offset = "0x10A28E0", VA = "0x1810A42E0")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal class Wrapper
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private const string lib_name = "opus_egpv";

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x10B29B0", Offset = "0x10B0FB0", VA = "0x1810B29B0")]
		private static extern int opus_encoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x10B2A40", Offset = "0x10B1040", VA = "0x1810B2A40")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x10B2B00", Offset = "0x10B1100", VA = "0x1810B2B00")]
		public static extern IntPtr opus_get_version_string();

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x10B23A0", Offset = "0x10B09A0", VA = "0x1810B23A0")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x10B2140", Offset = "0x10B0740", VA = "0x1810B2140")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x10B28A0", Offset = "0x10B0EA0", VA = "0x1810B28A0")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x10B27F0", Offset = "0x10B0DF0", VA = "0x1810B27F0")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x10B1EF0", Offset = "0x10B04F0", VA = "0x1810B1EF0")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x10B1E40", Offset = "0x10B0440", VA = "0x1810B1E40")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x10B2000", Offset = "0x10B0600", VA = "0x1810B2000")]
		private static extern int opus_decoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x10B2090", Offset = "0x10B0690", VA = "0x1810B2090")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A70", Offset = "0x10B0070", VA = "0x1810B1A70")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x10B1880", Offset = "0x10AFE80", VA = "0x1810B1880")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x10B2B90", Offset = "0x10B1190", VA = "0x1810B2B90")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x10B2C30", Offset = "0x10B1230", VA = "0x1810B2C30")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x10B2CD0", Offset = "0x10B12D0", VA = "0x1810B2CD0")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x10B2600", Offset = "0x10B0C00", VA = "0x1810B2600")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x10B2490", Offset = "0x10B0A90", VA = "0x1810B2490")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x10B2230", Offset = "0x10B0830", VA = "0x1810B2230")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x10B2950", Offset = "0x10B0F50", VA = "0x1810B2950")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x10B1760", Offset = "0x10AFD60", VA = "0x1810B1760")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x10B2E80", Offset = "0x10B1480", VA = "0x1810B2E80")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x10B1640", Offset = "0x10AFC40", VA = "0x1810B1640")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x10B2D60", Offset = "0x10B1360", VA = "0x1810B2D60")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x10B1C60", Offset = "0x10B0260", VA = "0x1810B1C60")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x10B1FA0", Offset = "0x10B05A0", VA = "0x1810B1FA0")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x10B1B60", Offset = "0x10B0160", VA = "0x1810B1B60")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x10B1970", Offset = "0x10AFF70", VA = "0x1810B1970")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x10B1510", Offset = "0x10AFB10", VA = "0x1810B1510")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public enum Bandwidth
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Narrowband = 1101,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Mediumband,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Wideband,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		SuperWideband,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Fullband
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum Channels
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Stereo
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum Complexity
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		Complexity0,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		Complexity1,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		Complexity2,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		Complexity3,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Complexity4,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Complexity5,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Complexity6,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Complexity7,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Complexity8,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Complexity9,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Complexity10
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum Delay
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Delay2dot5ms = 5,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Delay5ms = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Delay10ms = 20,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Delay20ms = 40,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Delay40ms = 80,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Delay60ms = 120
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum ForceChannels
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		NoForce = -1000,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Stereo = 2
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum OpusApplicationType
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Voip = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Audio = 2049,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		RestrictedLowDelay = 2051
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal enum OpusCtlGetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Application = 4001,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Bitrate = 4003,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		MaxBandwidth = 4005,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		VBR = 4007,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Bandwidth = 4009,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Complexity = 4011,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		InbandFec = 4013,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		PacketLossPercentage = 4015,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Dtx = 4017,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		VBRConstraint = 4021,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		ForceChannels = 4023,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Signal = 4025,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		LookAhead = 4027,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		SampleRate = 4029,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		FinalRange = 4031,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Pitch = 4033,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Gain = 4035,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		LsbDepth = 4037,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		LastPacketDurationRequest = 4039
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal enum OpusCtlSetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Application = 4000,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Bitrate = 4002,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		MaxBandwidth = 4004,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		VBR = 4006,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Bandwidth = 4008,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Complexity = 4010,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		InbandFec = 4012,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		PacketLossPercentage = 4014,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Dtx = 4016,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		VBRConstraint = 4020,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ForceChannels = 4022,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Signal = 4024,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Gain = 4034,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LsbDepth = 4036
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OpusStatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		OK = 0,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		BadArguments = -1,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		BufferTooSmall = -2,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		InternalError = -3,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		InvalidPacket = -4,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Unimplemented = -5,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		InvalidState = -6,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		AllocFail = -7
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Sampling08000 = 8000,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Sampling12000 = 12000,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Sampling16000 = 16000,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Sampling24000 = 24000,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Sampling48000 = 48000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum SignalHint
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Auto = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Voice = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class AudioUtil
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			protected T[] frameResampled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			private int channels;

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x11AD630", Offset = "0x11ABC30", VA = "0x1811AD630")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x11AD5E0", Offset = "0x11ABBE0", VA = "0x1811AD5E0", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		public interface ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000DF")]
			float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004AE")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E0")]
			float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004AF")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E1")]
			float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004B0")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E2")]
			float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004B1")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ResetAccumAvgPeakAmp();
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000E3")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004B3")]
				[Cpp2IlInjected.Address(RVA = "0x598D30", Offset = "0x597330", VA = "0x180598D30", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E4")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004B4")]
				[Cpp2IlInjected.Address(RVA = "0x598D30", Offset = "0x597330", VA = "0x180598D30", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E5")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004B5")]
				[Cpp2IlInjected.Address(RVA = "0x598D30", Offset = "0x597330", VA = "0x180598D30", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E6")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004B6")]
				[Cpp2IlInjected.Address(RVA = "0x598D30", Offset = "0x597330", VA = "0x180598D30", Slot = "7")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "8")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public LevelMetterDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			protected float ampSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			protected float ampPeak;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			protected int bufferSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			protected float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			protected int prevValuesPtr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			protected float accumAvgPeakAmpSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			protected int accumAvgPeakAmpCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			protected float peakAmpForFrame;

			[Cpp2IlInjected.Token(Token = "0x170000E7")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004BA")]
				[Cpp2IlInjected.Address(RVA = "0x119DCD0", Offset = "0x119C2D0", VA = "0x18119DCD0", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E8")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x539580", Offset = "0x537B80", VA = "0x180539580", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60004BC")]
				[Cpp2IlInjected.Address(RVA = "0x372A40", Offset = "0x371040", VA = "0x180372A40")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E9")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004BD")]
				[Cpp2IlInjected.Address(RVA = "0x5D3430", Offset = "0x5D1A30", VA = "0x1805D3430", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EA")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004BE")]
				[Cpp2IlInjected.Address(RVA = "0x119DCB0", Offset = "0x119C2B0", VA = "0x18119DCB0", Slot = "9")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x119DBB0", Offset = "0x119C1B0", VA = "0x18119DBB0")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x119DB20", Offset = "0x119C120", VA = "0x18119DB20", Slot = "10")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x13020B0", Offset = "0x13006B0", VA = "0x1813020B0")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x1301F00", Offset = "0x1300500", VA = "0x181301F00", Slot = "11")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x13022E0", Offset = "0x13008E0", VA = "0x1813022E0")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x1302110", Offset = "0x1300710", VA = "0x181302110", Slot = "11")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public interface IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			bool On
			{
				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004C7")]
				[Cpp2IlInjected.Address(Slot = "1")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(Slot = "3")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000ED")]
			bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x60004CA")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x60004CB")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004CF")]
				[Cpp2IlInjected.Address(Slot = "9")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			event Action OnDetected;
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private IVoiceDetector voiceDetector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private ILevelMeter levelMeter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private int valuesPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			protected int voiceDetectorCalibrateCount;

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			public bool VoiceDetectorCalibrating
			{
				[Cpp2IlInjected.Token(Token = "0x60004D0")]
				[Cpp2IlInjected.Address(RVA = "0x7C0D50", Offset = "0x7BF350", VA = "0x1807C0D50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x11AFA10", Offset = "0x11AE010", VA = "0x1811AFA10")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x11AF890", Offset = "0x11ADE90", VA = "0x1811AF890")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x11AF730", Offset = "0x11ADD30", VA = "0x1811AF730", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60004D6")]
				[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0x598D30", Offset = "0x597330", VA = "0x180598D30", Slot = "6")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "7")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x310D30", Offset = "0x30F330", VA = "0x180310D30", Slot = "12")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "13")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x60004DE")]
				[Cpp2IlInjected.Address(RVA = "0x1315B60", Offset = "0x1314160", VA = "0x181315B60", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004DF")]
				[Cpp2IlInjected.Address(RVA = "0x1315C00", Offset = "0x1314200", VA = "0x181315C00", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private bool detected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			protected int activityDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			protected int autoSilenceCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			protected int valuesCountPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			protected int activityDelayValuesCount;

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x338520", Offset = "0x336B20", VA = "0x180338520", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x2E4260", Offset = "0x2E2860", VA = "0x1802E4260", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F7")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x6D51C0", Offset = "0x6D37C0", VA = "0x1806D51C0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x6D51E0", Offset = "0x6D37E0", VA = "0x1806D51E0", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x2EA6B0", Offset = "0x2E8CB0", VA = "0x1802EA6B0", Slot = "10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x11B00B0", Offset = "0x11AE6B0", VA = "0x1811B00B0")]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x60004E7")]
				[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0x4720D0", Offset = "0x4706D0", VA = "0x1804720D0", Slot = "14")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x11AFF20", Offset = "0x11AE520", VA = "0x1811AFF20", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x11AFC60", Offset = "0x11AE260", VA = "0x1811AFC60", Slot = "12")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x11AFD10", Offset = "0x11AE310", VA = "0x1811AFD10", Slot = "13")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0x11AFA70", Offset = "0x11AE070", VA = "0x1811AFA70")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(Slot = "16")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x1315DD0", Offset = "0x13143D0", VA = "0x181315DD0")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x1315CA0", Offset = "0x13142A0", VA = "0x181315CA0", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x1315F80", Offset = "0x1314580", VA = "0x181315F80")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x1315E40", Offset = "0x1314440", VA = "0x181315E40", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			private VoiceDetectorCalibration<T> c;

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			public ILevelMeter Level
			{
				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60004F5")]
				[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			public IVoiceDetector Detector
			{
				[Cpp2IlInjected.Token(Token = "0x60004F6")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60004F7")]
				[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x11B0830", Offset = "0x11AEE30", VA = "0x1811B0830")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x11B0160", Offset = "0x11AE760", VA = "0x1811B0160")]
			public void Calibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x11B0640", Offset = "0x11AEC40", VA = "0x1811B0640", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x11B0190", Offset = "0x11AE790", VA = "0x1811B0190", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public const float SHORT_TO_NORMALIZED_FLOAT_RATIO = 3.051851E-05f;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x189A8D0", Offset = "0x1898ED0", VA = "0x18189A8D0")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x12FF2A0", Offset = "0x12FD8A0", VA = "0x1812FF2A0")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x12FEFE0", Offset = "0x12FD5E0", VA = "0x1812FEFE0")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x12FEF60", Offset = "0x12FD560", VA = "0x1812FEF60")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x12FEED0", Offset = "0x12FD4D0", VA = "0x1812FEED0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x189A7C0", Offset = "0x1898DC0", VA = "0x18189A7C0")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x114E580", Offset = "0x114CB80", VA = "0x18114E580")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface IAudioOut
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		int CurrentBufferLag
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnAudioFrame(float[] frame);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Service();

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Pause();
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		protected int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		protected TInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TType[] freeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		protected int pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool inited;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x11A8D20", Offset = "0x11A7320", VA = "0x1811A8D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public TInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			get
			{
				return (TInfo)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TType createObject(TInfo info);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void destroyObject(TType obj);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x11A8BA0", Offset = "0x11A71A0", VA = "0x1811A8BA0")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x11A8C10", Offset = "0x11A7210", VA = "0x1811A8C10")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x11A8470", Offset = "0x11A6A70", VA = "0x1811A8470")]
		public void Init(TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x11A7E70", Offset = "0x11A6470", VA = "0x1811A7E70")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x11A8020", Offset = "0x11A6620", VA = "0x1811A8020")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x11A89A0", Offset = "0x11A6FA0", VA = "0x1811A89A0", Slot = "8")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x11A8850", Offset = "0x11A6E50", VA = "0x1811A8850", Slot = "9")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x11A8230", Offset = "0x11A6830", VA = "0x1811A8230", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x11A8DC0", Offset = "0x11A73C0", VA = "0x1811A8DC0")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x11A8DF0", Offset = "0x11A73F0", VA = "0x1811A8DF0")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x11A8E20", Offset = "0x11A7420", VA = "0x1811A8E20", Slot = "5")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "6")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA6B4B0", Offset = "0xA69AB0", VA = "0x180A6B4B0", Slot = "7")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Factory factory;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x119D720", Offset = "0x119BD20", VA = "0x18119D720")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x119D770", Offset = "0x119BD70", VA = "0x18119D770")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x119D7D0", Offset = "0x119BDD0", VA = "0x18119D7D0", Slot = "5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x119D810", Offset = "0x119BE10", VA = "0x18119D810", Slot = "6")]
		protected override void destroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x119D840", Offset = "0x119BE40", VA = "0x18119D840", Slot = "7")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class OpusCodec
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		public enum FrameDuration
		{
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			Frame2dot5ms = 2500,
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			Frame5ms = 5000,
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			Frame10ms = 10000,
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			Frame20ms = 20000,
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			Frame40ms = 40000,
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			Frame60ms = 60000
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public static class EncoderFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000500")]
			[Cpp2IlInjected.Address(RVA = "0x1300830", Offset = "0x12FEE30", VA = "0x181300830")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			protected OpusEncoder encoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			protected bool disposed;

			[Cpp2IlInjected.Token(Token = "0x6000501")]
			[Cpp2IlInjected.Address(RVA = "0x119CA40", Offset = "0x119B040", VA = "0x18119CA40")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000502")]
			[Cpp2IlInjected.Address(RVA = "0x119C8A0", Offset = "0x119AEA0", VA = "0x18119C8A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000503")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		public class EncoderFloat : Encoder<float>
		{
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x1300C60", Offset = "0x12FF260", VA = "0x181300C60")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000505")]
			[Cpp2IlInjected.Address(RVA = "0x1300A90", Offset = "0x12FF090", VA = "0x181300A90", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		public class EncoderShort : Encoder<short>
		{
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x1300EA0", Offset = "0x12FF4A0", VA = "0x181300EA0")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000508")]
			[Cpp2IlInjected.Address(RVA = "0x1300CD0", Offset = "0x12FF2D0", VA = "0x181300CD0", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			private OpusDecoder decoder;

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x12FFD30", Offset = "0x12FE330", VA = "0x1812FFD30", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050B")]
			[Cpp2IlInjected.Address(RVA = "0x12FFC80", Offset = "0x12FE280", VA = "0x1812FFC80", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0x12FFCD0", Offset = "0x12FE2D0", VA = "0x1812FFCD0", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x12FFCF0", Offset = "0x12FE2F0", VA = "0x1812FFCF0", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0x12FFD10", Offset = "0x12FE310", VA = "0x1812FFD10", Slot = "8")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public Decoder()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		public class Util
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x1315920", Offset = "0x1313F20", VA = "0x181315920")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
			public Util()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public OpusCodec()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public struct AECLatencyResultType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public int LatencyMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public int LatencyDelayedMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public bool PlayDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public bool PlayDelayedDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public bool RecDetected;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool _AEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private int _AECPlaybackDelayMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool _AECLatencyDetect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int frameSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int samplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private int playDelayFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int playDelayMaxFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private IntPtr stEcho;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private IntPtr st;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private short[] resultBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Queue<short[]> playBufQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Framer<float> playFramer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int playSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private int playChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private Func<long> clockMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private long detectTimePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private long detectTimePlayDelayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private long detectTimeRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int frameCntRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private int frameCntPlay;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x338520", Offset = "0x336B20", VA = "0x180338520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1314BF0", Offset = "0x13131F0", VA = "0x181314BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int AECFilterLengthMs
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int AECPlaybackDelayMs
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x1314BD0", Offset = "0x13131D0", VA = "0x181314BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int AECurrentPlayDelayFrames
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x1314AD0", Offset = "0x13130D0", VA = "0x181314AD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool AECLatencyDetect
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x538CE0", Offset = "0x5372E0", VA = "0x180538CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1314BB0", Offset = "0x13131B0", VA = "0x181314BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AECLatencyResultType AECLatencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x13149A0", Offset = "0x1312FA0", VA = "0x1813149A0")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool Denoise
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x1314B80", Offset = "0x1313180", VA = "0x181314B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x1314CB0", Offset = "0x13132B0", VA = "0x181314CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool AGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x1314B50", Offset = "0x1313150", VA = "0x181314B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x1314C80", Offset = "0x1313280", VA = "0x181314C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public float AGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x1314B20", Offset = "0x1313120", VA = "0x181314B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x1314C50", Offset = "0x1313250", VA = "0x181314C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x13144A0", Offset = "0x1312AA0", VA = "0x1813144A0")]
		public void ResetAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1312A80", Offset = "0x1311080", VA = "0x181312A80")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1314CE0", Offset = "0x13132E0", VA = "0x181314CE0")]
		private void set(int param, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1314D10", Offset = "0x1313310", VA = "0x181314D10")]
		private void set(int param, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1314940", Offset = "0x1312F40", VA = "0x181314940")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1314970", Offset = "0x1312F70", VA = "0x181314970")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1314620", Offset = "0x1312C20", VA = "0x181314620")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1313690", Offset = "0x1311C90", VA = "0x181313690")]
		private void InitLatencyDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1312D60", Offset = "0x1311360", VA = "0x181312D60")]
		public void InitAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1313890", Offset = "0x1311E90", VA = "0x181313890")]
		private void InitPlayDelay(int ms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1314030", Offset = "0x1312630", VA = "0x181314030", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1313950", Offset = "0x1311F50", VA = "0x181313950")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0")]
		public void PrintInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1312B10", Offset = "0x1311110", VA = "0x181312B10")]
		private void DestroyEchoState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1312C00", Offset = "0x1311200", VA = "0x181312C00", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class SpeexLib
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private const string lib_name = "libspeexdsp";

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x13129E0", Offset = "0x1310FE0", VA = "0x1813129E0")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1312950", Offset = "0x1310F50", VA = "0x181312950")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x13128A0", Offset = "0x1310EA0", VA = "0x1813128A0")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1312590", Offset = "0x1310B90", VA = "0x181312590")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1312760", Offset = "0x1310D60", VA = "0x181312760")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1312640", Offset = "0x1310C40", VA = "0x181312640")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x13123A0", Offset = "0x13109A0", VA = "0x1813123A0")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1312440", Offset = "0x1310A40", VA = "0x181312440")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1312310", Offset = "0x1310910", VA = "0x181312310")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1311D70", Offset = "0x1310370", VA = "0x181311D70")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1311E50", Offset = "0x1310450", VA = "0x181311E50")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1312260", Offset = "0x1310860", VA = "0x181312260")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1312500", Offset = "0x1310B00", VA = "0x181312500")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1311F20", Offset = "0x1310520", VA = "0x181311F20")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1312120", Offset = "0x1310720", VA = "0x181312120")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1311FD0", Offset = "0x13105D0", VA = "0x181311FD0")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public SpeexLib()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public interface IDataReader<T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Read(T[] buffer);
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public interface IServiceable
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Service(LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class LocalVoice : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const int DATA_POOL_CAPACITY = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private bool debugEchoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		internal VoiceInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		protected IEncoder encoder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		internal byte id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		internal int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		internal byte evNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private int noTransmitCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		internal Dictionary<byte, int> eventTimestamps;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public byte Group
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x338520", Offset = "0x336B20", VA = "0x180338520")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2E4260", Offset = "0x2E2860", VA = "0x1802E4260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x130C250", Offset = "0x130A850", VA = "0x18130C250")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool Transmit
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x3F8AA0", Offset = "0x3F70A0", VA = "0x1803F8AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x5C2770", Offset = "0x5C0D70", VA = "0x1805C2770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool IsTransmitting
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x769C30", Offset = "0x768230", VA = "0x180769C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x769C50", Offset = "0x768250", VA = "0x180769C50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool Reliable
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x538CE0", Offset = "0x5372E0", VA = "0x180538CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x769C40", Offset = "0x768240", VA = "0x180769C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool Encrypt
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x130C240", Offset = "0x130A840", VA = "0x18130C240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x130CB40", Offset = "0x130B140", VA = "0x18130CB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public IServiceable LocalUserServiceable
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool DebugEchoMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2E61D0", Offset = "0x2E47D0", VA = "0x1802E61D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x130CAD0", Offset = "0x130B0D0", VA = "0x18130CAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		internal string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x130C2C0", Offset = "0x130A8C0", VA = "0x18130C2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x130C270", Offset = "0x130A870", VA = "0x18130C270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x130C1B0", Offset = "0x130A7B0", VA = "0x18130C1B0")]
		internal LocalVoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x130C0C0", Offset = "0x130A6C0", VA = "0x18130C0C0")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x130C4C0", Offset = "0x130AAC0", VA = "0x18130C4C0")]
		protected void resetNoTransmitCnt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x130C660", Offset = "0x130AC60", VA = "0x18130C660", Slot = "5")]
		internal virtual void service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x130C4D0", Offset = "0x130AAD0", VA = "0x18130C4D0")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x130C090", Offset = "0x130A690", VA = "0x18130C090")]
		public void RemoveSelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x130C020", Offset = "0x130A620", VA = "0x18130C020", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public struct RemoteVoiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2B20", Offset = "0x1F20", VA = "0x180002B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x37B0", Offset = "0x2BB0", VA = "0x1800037B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0", Offset = "0x6EB0", VA = "0x180007AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x6D50", Offset = "0x6150", VA = "0x180006D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xCD50", Offset = "0xC150", VA = "0x18000CD50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x6D30", Offset = "0x6130", VA = "0x180006D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x20ED20", Offset = "0x20E120", VA = "0x18020ED20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6D40", Offset = "0x6140", VA = "0x180006D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2B30", Offset = "0x1F30", VA = "0x180002B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x5460", Offset = "0x4860", VA = "0x180005460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public IDecoder Decoder
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x7AA0", Offset = "0x6EA0", VA = "0x180007AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x22D250", Offset = "0x22C650", VA = "0x18022D250")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	internal class RemoteVoice : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		internal RemoteVoiceOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private byte voiceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		internal byte lastEvNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Queue<byte[]> frameQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private AutoResetEvent frameQueueReady;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xF01960", Offset = "0xEFFF60", VA = "0x180F01960")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x130E2B0", Offset = "0x130C8B0", VA = "0x18130E2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x130F4B0", Offset = "0x130DAB0", VA = "0x18130F4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		protected string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x130F460", Offset = "0x130DA60", VA = "0x18130F460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x130E3B0", Offset = "0x130C9B0", VA = "0x18130E3B0")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x130E630", Offset = "0x130CC30", VA = "0x18130E630")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x130F790", Offset = "0x130DD90", VA = "0x18130F790")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x130FCB0", Offset = "0x130E2B0", VA = "0x18130FCB0")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x130FE60", Offset = "0x130E460", VA = "0x18130FE60")]
		private void receiveNullFrames(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x130EE20", Offset = "0x130D420", VA = "0x18130EE20")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x130EC40", Offset = "0x130D240", VA = "0x18130EC40")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x130E640", Offset = "0x130CC40", VA = "0x18130E640")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x130EA40", Offset = "0x130D040", VA = "0x18130EA40")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x130E840", Offset = "0x130CE40", VA = "0x18130E840")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1310010", Offset = "0x130E610", VA = "0x181310010")]
		internal void removeAndDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x130E2D0", Offset = "0x130C8D0", VA = "0x18130E2D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface IAudioSource : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public interface ILocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class LocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static LocalVoiceAudioDummy Dummy;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE50CC0", Offset = "0xE4F2C0", VA = "0x180E50CC0")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		protected int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		protected int sourceSamplingRateHz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		protected bool resampleSource;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x546A30", Offset = "0x545030", VA = "0x180546A30", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x5A0270", Offset = "0x59E870", VA = "0x1805A0270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x119ED10", Offset = "0x119D310", VA = "0x18119ED10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x119DCF0", Offset = "0x119C2F0", VA = "0x18119DCF0", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x119E7C0", Offset = "0x119CDC0", VA = "0x18119E7C0")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x119ED40", Offset = "0x119D340", VA = "0x18119ED40")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x550290", Offset = "0x54E890", VA = "0x180550290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x4843F0", Offset = "0x4829F0", VA = "0x1804843F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2E61E0", Offset = "0x2E47E0", VA = "0x1802E61E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x130B9F0", Offset = "0x1309FF0", VA = "0x18130B9F0")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x130BAD0", Offset = "0x130A0D0", VA = "0x18130BAD0")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x130BC70", Offset = "0x130A270", VA = "0x18130BC70")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal enum EventSubcode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		VoiceInfo = 1,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		VoiceRemove,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Frame
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal enum EventParam : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		VoiceId = 1,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		SamplingRate = 2,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		Channels = 3,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		FrameDurationUs = 4,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		Bitrate = 5,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		UserData = 10,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		EventNumber = 11,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		Codec = 12
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogError(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogWarning(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LogInfo(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LogDebug(string fmt, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal interface IVoiceFrontend : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AssignChannel(VoiceInfo v);

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IsChannelJoined(int channelId);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ChannelIdStr(int channelId);

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		string PlayerIdStr(int playerId);

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class VoiceClient : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private RemoteVoiceInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			RemoteVoiceInfo IEnumerator<RemoteVoiceInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600051F")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000521")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0xB187D0", Offset = "0xB16DD0", VA = "0x180B187D0")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x10AAAF0", Offset = "0x10A90F0", VA = "0x1810AAAF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x10AA570", Offset = "0x10A8B70", VA = "0x1810AA570", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x10AABF0", Offset = "0x10A91F0", VA = "0x1810AABF0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x10AAC30", Offset = "0x10A9230", VA = "0x1810AAC30")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x10AAC70", Offset = "0x10A9270", VA = "0x1810AAC70")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x10AAAA0", Offset = "0x10A90A0", VA = "0x1810AAAA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x10AAA00", Offset = "0x10A9000", VA = "0x1810AAA00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0x10AAA00", Offset = "0x10A9000", VA = "0x1810AAA00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052A")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000100")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0xB187D0", Offset = "0xB16DD0", VA = "0x180B187D0")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0x10AB130", Offset = "0x10A9730", VA = "0x1810AB130", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000526")]
			[Cpp2IlInjected.Address(RVA = "0x10AACC0", Offset = "0x10A92C0", VA = "0x1810AACC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x10AB230", Offset = "0x10A9830", VA = "0x1810AB230")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x10AB270", Offset = "0x10A9870", VA = "0x1810AB270")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x10AB2B0", Offset = "0x10A98B0", VA = "0x1810AB2B0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x10AB0E0", Offset = "0x10A96E0", VA = "0x1810AB0E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x10AB040", Offset = "0x10A9640", VA = "0x1810AB040", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x10AB040", Offset = "0x10A9640", VA = "0x1810AB040", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal IVoiceFrontend frontend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int prevRtt;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const int ChannelAuto = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private byte globalGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private byte voiceIdCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private System.Random rnd;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int FramesLost
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int FramesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2F4C60", Offset = "0x2F3260", VA = "0x1802F4C60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x32A590", Offset = "0x328B90", VA = "0x18032A590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x10ADDB0", Offset = "0x10AC3B0", VA = "0x1810ADDB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x10ADC30", Offset = "0x10AC230", VA = "0x1810ADC30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int RoundTripTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2F4B50", Offset = "0x2F3150", VA = "0x1802F4B50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x303810", Offset = "0x301E10", VA = "0x180303810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int RoundTripTimeVariance
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x3035A0", Offset = "0x301BA0", VA = "0x1803035A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x349820", Offset = "0x347E20", VA = "0x180349820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool SuppressInfoDuplicateWarning
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2F7B80", Offset = "0x2F6180", VA = "0x1802F7B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x2F7B90", Offset = "0x2F6190", VA = "0x1802F7B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA40", Offset = "0x2FA040", VA = "0x1802FBA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA50", Offset = "0x2FA050", VA = "0x1802FBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int DebugLostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x31B320", Offset = "0x319920", VA = "0x18031B320")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x37F160", Offset = "0x37D760", VA = "0x18037F160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x10ADF30", Offset = "0x10AC530", VA = "0x1810ADF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x10ADFD0", Offset = "0x10AC5D0", VA = "0x1810ADFD0")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x10AE040", Offset = "0x10AC640", VA = "0x1810AE040")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		internal byte GlobalGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x308C50", Offset = "0x307250", VA = "0x180308C50")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x10B07A0", Offset = "0x10AEDA0", VA = "0x1810B07A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x10ABC20", Offset = "0x10AA220", VA = "0x1810ABC20")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x10AC040", Offset = "0x10AA640", VA = "0x1810AC040")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x10ABED0", Offset = "0x10AA4D0", VA = "0x1810ABED0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x10AD6F0", Offset = "0x10ABCF0", VA = "0x1810AD6F0")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x10AB5C0", Offset = "0x10A9BC0", VA = "0x1810AB5C0")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xE5A9F0", Offset = "0xE58FF0", VA = "0x180E5A9F0")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xE5A570", Offset = "0xE58B70", VA = "0x180E5A570")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x10ADA10", Offset = "0x10AC010", VA = "0x1810ADA10")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x10AC120", Offset = "0x10AA720", VA = "0x1810AC120")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x10ABCF0", Offset = "0x10AA2F0", VA = "0x1810ABCF0")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x10B05B0", Offset = "0x10AEBB0", VA = "0x1810B05B0")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x10B04F0", Offset = "0x10AEAF0", VA = "0x1810B04F0")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x10AE950", Offset = "0x10ACF50", VA = "0x1810AE950")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x10AC4F0", Offset = "0x10AAAF0", VA = "0x1810AC4F0")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x10AC2C0", Offset = "0x10AA8C0", VA = "0x1810AC2C0")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x10AD2B0", Offset = "0x10AB8B0", VA = "0x1810AD2B0")]
		internal void clearRemoteVoices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x10ACF20", Offset = "0x10AB520", VA = "0x1810ACF20")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10AED90", Offset = "0x10AD390", VA = "0x1810AED90")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10AF710", Offset = "0x10ADD10", VA = "0x1810AF710")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x10AE0B0", Offset = "0x10AC6B0", VA = "0x1810AE0B0")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10B03B0", Offset = "0x10AE9B0", VA = "0x1810B03B0")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10B01A0", Offset = "0x10AE7A0", VA = "0x1810B01A0")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10ACCE0", Offset = "0x10AB2E0", VA = "0x1810ACCE0")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x10AFF60", Offset = "0x10AE560", VA = "0x1810AFF60")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x10AB6D0", Offset = "0x10A9CD0", VA = "0x1810AB6D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public interface IEncoder : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public interface IDecoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Open(VoiceInfo info);
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(Slot = "0")]
		byte[] DecodeToByte(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float[] DecodeToFloat(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(Slot = "2")]
		short[] DecodeToShort(byte[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Decode(byte[] buf);
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		ImageFormat OutputImageFormat
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		Flip OutputImageFlip
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		OnImageOutputNative OnOutputImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x10AB540", Offset = "0x10A9B40", VA = "0x1810AB540")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	internal class UnsupportedCodecException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10AB300", Offset = "0x10A9900", VA = "0x1810AB300")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public enum Codec
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		AudioOpus = 11
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public enum ImageFormat
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		I420,
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		YV12,
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		Android420,
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		ABGR,
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		BGRA,
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		ARGB
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public enum Rotation
	{
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		Rotate0 = 0,
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		Rotate90 = 90,
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		Rotate180 = 180,
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		Rotate270 = 270
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public enum Flip
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class ImageBufferInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x2EB980", Offset = "0x2E9F80", VA = "0x1802EB980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x33B820", Offset = "0x339E20", VA = "0x18033B820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x3F96C0", Offset = "0x3F7CC0", VA = "0x1803F96C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x2E4270", Offset = "0x2E2870", VA = "0x1802E4270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int[] Stride
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ImageFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x2F4B50", Offset = "0x2F3150", VA = "0x1802F4B50")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x303810", Offset = "0x301E10", VA = "0x180303810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Rotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x3035A0", Offset = "0x301BA0", VA = "0x1803035A0")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x349820", Offset = "0x347E20", VA = "0x180349820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Flip Flip
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x3017E0", Offset = "0x2FFDE0", VA = "0x1803017E0")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x301990", Offset = "0x2FFF90", VA = "0x180301990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1301AC0", Offset = "0x13000C0", VA = "0x181301AC0")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public ImageBufferInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public IntPtr[] Planes
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x3024B0", Offset = "0x300AB0", VA = "0x1803024B0")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "4")]
		public virtual void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1301C00", Offset = "0x1300200", VA = "0x181301C00")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1301BE0", Offset = "0x13001E0", VA = "0x181301BE0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1301B10", Offset = "0x1300110", VA = "0x181301B10", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private GCHandle planeHandle;

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1301DF0", Offset = "0x13003F0", VA = "0x181301DF0")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1301D40", Offset = "0x1300340", VA = "0x181301D40")]
		public void PinPlane(byte[] plane)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1301DB0", Offset = "0x13003B0", VA = "0x181301DB0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal static class VoiceCodec
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x10B0980", Offset = "0x10AEF80", VA = "0x1810B0980")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x10B0920", Offset = "0x10AEF20", VA = "0x1810B0920")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class Framer<T>
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private T[] <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public Framer<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private T[] buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public T[] <>3__buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private int <s>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private int <bufPos>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0xE71B00", Offset = "0xE70100", VA = "0x180E71B00")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E36D0", VA = "0x1802E50D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x11AD970", Offset = "0x11ABF70", VA = "0x1811AD970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x11ADC60", Offset = "0x11AC260", VA = "0x1811ADC60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x11ADAE0", Offset = "0x11AC0E0", VA = "0x1811ADAE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x11ADB90", Offset = "0x11AC190", VA = "0x1811ADB90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private T[] frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private int sizeofT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private int framePos;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x119CF80", Offset = "0x119B580", VA = "0x18119CF80")]
		public Framer(int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x119CEB0", Offset = "0x119B4B0", VA = "0x18119CEB0")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x119CEE0", Offset = "0x119B4E0", VA = "0x18119CEE0")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x4843C0", Offset = "0x4829C0", VA = "0x1804843C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x484440", Offset = "0x482A40", VA = "0x180484440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x130BF30", Offset = "0x130A530", VA = "0x18130BF30")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public interface IProcessor : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			T[] Process(T[] buf);
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Framer<T> framer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int preProcessorsCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private List<IProcessor> processors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool dataEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private Queue<T[]> pushDataQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private AutoResetEvent pushDataQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int framesSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF060", VA = "0x1805C0A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool PushDataAsyncReady
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x11A2E80", Offset = "0x11A1480", VA = "0x1811A2E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x11A2F60", Offset = "0x11A1560", VA = "0x1811A2F60")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x119F070", Offset = "0x119D670", VA = "0x18119F070")]
		public void AddPostProcessor(params IProcessor[] processors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x119F180", Offset = "0x119D780", VA = "0x18119F180")]
		public void AddPreProcessor(params IProcessor[] processors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x119F2A0", Offset = "0x119D8A0", VA = "0x18119F2A0")]
		public void ClearProcessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x11A26A0", Offset = "0x11A0CA0", VA = "0x1811A26A0")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x11A1060", Offset = "0x119F660", VA = "0x1811A1060")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x11A03D0", Offset = "0x119E9D0", VA = "0x1811A03D0")]
		private void PushDataAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x11A1C60", Offset = "0x11A0260", VA = "0x1811A1C60")]
		public void PushData(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x119F760", Offset = "0x119DD60", VA = "0x18119F760", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 40)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public struct VoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Codec Codec
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x8DB0", Offset = "0x81B0", VA = "0x180008DB0")]
			[CompilerGenerated]
			get
			{
				return default(Codec);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x6D20", Offset = "0x6120", VA = "0x180006D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x8D80", Offset = "0x8180", VA = "0x180008D80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x18D9B0", Offset = "0x18CDB0", VA = "0x18018D9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int SourceSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D50", Offset = "0x8150", VA = "0x180008D50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xD250", Offset = "0xC650", VA = "0x18000D250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x7A90", Offset = "0x6E90", VA = "0x180007A90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x20ED40", Offset = "0x20E140", VA = "0x18020ED40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int FrameDurationUs
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x8D70", Offset = "0x8170", VA = "0x180008D70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x20ED50", Offset = "0x20E150", VA = "0x18020ED50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DA0", Offset = "0x81A0", VA = "0x180008DA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x20ED30", Offset = "0x20E130", VA = "0x18020ED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public object UserData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x20ED20", Offset = "0x20E120", VA = "0x18020ED20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D40", Offset = "0x6140", VA = "0x180006D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int FrameDurationSamples
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x20ECB0", Offset = "0x20E0B0", VA = "0x18020ECB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x20ECE0", Offset = "0x20E0E0", VA = "0x18020ECE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x923F0", Offset = "0x917F0", VA = "0x1800923F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x20ED70", Offset = "0x20E170", VA = "0x18020ED70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x20ED10", Offset = "0x20E110", VA = "0x18020ED10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x20ED60", Offset = "0x20E160", VA = "0x18020ED60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x10B0A70", Offset = "0x10AF070", VA = "0x1810B0A70")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x20ECA0", Offset = "0x20E0A0", VA = "0x18020ECA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x10B0AD0", Offset = "0x10AF0D0", VA = "0x1810B0AD0")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class RemoteVoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xF01960", Offset = "0xEFFF60", VA = "0x180F01960")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x130E2B0", Offset = "0x130C8B0", VA = "0x18130E2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public int ChannelId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x31B320", Offset = "0x319920", VA = "0x18031B320")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x37F160", Offset = "0x37D760", VA = "0x18037F160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x4720B0", Offset = "0x4706B0", VA = "0x1804720B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x472110", Offset = "0x470710", VA = "0x180472110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public byte VoiceId
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x308C50", Offset = "0x307250", VA = "0x180308C50")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x308E60", Offset = "0x307460", VA = "0x180308E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x305D40", Offset = "0x304340", VA = "0x180305D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x3AF6B0", Offset = "0x3ADCB0", VA = "0x1803AF6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x130E240", Offset = "0x130C840", VA = "0x18130E240")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		protected IDataReader<T> reader;

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Service(LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xFB7C50", Offset = "0xFB6250", VA = "0x180FB7C50")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x119BA00", Offset = "0x119A000", VA = "0x18119BA00")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x119BC00", Offset = "0x119A200", VA = "0x18119BC00")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x119BA50", Offset = "0x119A050", VA = "0x18119BA50", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x119B930", Offset = "0x1199F30", VA = "0x18119B930")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x119B720", Offset = "0x1199D20", VA = "0x18119B720", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x119B620", Offset = "0x1199C20", VA = "0x18119B620")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x119B450", Offset = "0x1199A50", VA = "0x18119B450", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private float[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x12FFAA0", Offset = "0x12FE0A0", VA = "0x1812FFAA0")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x12FF820", Offset = "0x12FDE20", VA = "0x1812FF820", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal class VoiceEventCode
	{
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public const byte Code0 = 201;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x10B0A30", Offset = "0x10AF030", VA = "0x1810B0A30")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x10B0A40", Offset = "0x10AF040", VA = "0x1810B0A40")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public VoiceEventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private object sendLock;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public VoiceClient VoiceClient
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x6AEFE0", Offset = "0x6AD5E0", VA = "0x1806AEFE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public new Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x6BA490", Offset = "0x6B8A90", VA = "0x1806BA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9DAE90", Offset = "0x9D9490", VA = "0x1809DAE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x81A5E0", Offset = "0x818BE0", VA = "0x18081A5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x123A1B0", Offset = "0x12387B0", VA = "0x18123A1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public byte GlobalAudioGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x1308E50", Offset = "0x1307450", VA = "0x181308E50")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x13093C0", Offset = "0x13079C0", VA = "0x1813093C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x1307F60", Offset = "0x1306560", VA = "0x181307F60", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x1307FE0", Offset = "0x13065E0", VA = "0x181307FE0", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x1307FA0", Offset = "0x13065A0", VA = "0x181307FA0", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x1307F20", Offset = "0x1306520", VA = "0x181307F20", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x1307DF0", Offset = "0x13063F0", VA = "0x181307DF0", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x1307F10", Offset = "0x1306510", VA = "0x181307F10", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x1308AC0", Offset = "0x13070C0", VA = "0x181308AC0", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x1308BC0", Offset = "0x13071C0", VA = "0x181308BC0")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x1308A80", Offset = "0x1307080", VA = "0x181308A80")]
		public new void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x1307EB0", Offset = "0x13064B0", VA = "0x181307EB0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x1308720", Offset = "0x1306D20", VA = "0x181308720", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x1308020", Offset = "0x1306620", VA = "0x181308020")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x13084F0", Offset = "0x1306AF0", VA = "0x1813084F0", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x1308180", Offset = "0x1306780", VA = "0x181308180", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x310D30", Offset = "0x30F330", VA = "0x180310D30", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x310D30", Offset = "0x30F330", VA = "0x180310D30", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1308E80", Offset = "0x1307480", VA = "0x181308E80")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x1309250", Offset = "0x1307850", VA = "0x181309250")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1309180", Offset = "0x1307780", VA = "0x181309180")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1307EE0", Offset = "0x13064E0", VA = "0x181307EE0", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class AudioInEnumerator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private const string lib_name = "AudioIn";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private IntPtr handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public readonly bool IsSupported;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x12FDBE0", Offset = "0x12FC1E0", VA = "0x1812FDBE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x12FD5E0", Offset = "0x12FBBE0", VA = "0x1812FD5E0")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x12FD670", Offset = "0x12FBC70", VA = "0x1812FD670")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x12FD710", Offset = "0x12FBD10", VA = "0x1812FD710")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x12FD860", Offset = "0x12FBE60", VA = "0x1812FD860")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x12FD7B0", Offset = "0x12FBDB0", VA = "0x1812FD7B0")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x12FDA70", Offset = "0x12FC070", VA = "0x1812FDA70")]
		public AudioInEnumerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x12FD910", Offset = "0x12FBF10", VA = "0x1812FD910")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x12FD4F0", Offset = "0x12FBAF0", VA = "0x1812FD4F0")]
		public string NameAtIndex(int idx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x12FD430", Offset = "0x12FBA30", VA = "0x1812FD430")]
		public int IDAtIndex(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x12FD4E0", Offset = "0x12FBAE0", VA = "0x1812FD4E0")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x12FD350", Offset = "0x12FB950", VA = "0x1812FD350", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1301170", Offset = "0x12FF770", VA = "0x181301170")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1300F10", Offset = "0x12FF510", VA = "0x181300F10")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x13018C0", Offset = "0x12FFEC0", VA = "0x1813018C0")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1301920", Offset = "0x12FFF20", VA = "0x181301920")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1301690", Offset = "0x12FFC90", VA = "0x181301690")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1301430", Offset = "0x12FFA30", VA = "0x181301430")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x724720", Offset = "0x722D20", VA = "0x180724720")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class FriendInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2EA6B0", Offset = "0x2E8CB0", VA = "0x1802EA6B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2F77D0", Offset = "0x2F5DD0", VA = "0x1802F77D0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool IsInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x72D720", Offset = "0x72BD20", VA = "0x18072D720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1301A40", Offset = "0x1300040", VA = "0x181301A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public FriendInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public enum ClientState
	{
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		PeerCreated = 0,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		Authenticating = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Authenticated = 2,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		JoinedLobby = 3,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		DisconnectingFromMasterserver = 4,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		ConnectingToGameserver = 5,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		ConnectedToGameserver = 6,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Joining = 7,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		Joined = 8,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		Leaving = 9,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		DisconnectingFromGameserver = 10,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		ConnectingToMasterserver = 11,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		Disconnecting = 12,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		Disconnected = 13,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		ConnectedToMasterserver = 14,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[Obsolete]
		ConnectedToMaster = 14,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		ConnectingToNameServer = 15,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		ConnectedToNameServer = 16,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		DisconnectingFromNameServer = 17
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	internal enum JoinType
	{
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		CreateRoom,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		JoinRoom,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		JoinRandomRoom,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		JoinOrCreateRoom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public enum DisconnectCause
	{
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		DisconnectByServerUserLimit,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		ExceptionOnConnect,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		DisconnectByServer,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		TimeoutDisconnect,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		Exception,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		InvalidAuthentication,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		MaxCcuReached,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		InvalidRegion,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		OperationNotAllowedInCurrentState,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		CustomAuthenticationFailed,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		DisconnectByServerLogic
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public enum ServerConnection
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		MasterServer,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		GameServer,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		NameServer
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum EncryptionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		PayloadEncryption = 0,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		DatagramEncryption = 10,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		DatagramEncryptionRandomSequence = 11
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public static class EncryptionDataParameters
	{
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public const byte Mode = 0;

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public const byte Secret1 = 1;

		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public const byte Secret2 = 2;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LoadBalancingPeer loadBalancingPeer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AuthModeOption AuthMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public EncryptionMode EncryptionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ConnectionProtocol ExpectedProtocol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public string NameServerHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public string NameServerHttp;

		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private ClientState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private bool inLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private bool autoJoinLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public bool EnableLobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public Room CurrentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private JoinType lastJoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private bool didAuthenticate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private string[] friendListRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int friendListTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool isFetchingFriendList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private byte[] encryptionSecret;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public string AppVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public AuthenticationValues AuthValues
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private string TokenForInit
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x1307AE0", Offset = "0x13060E0", VA = "0x181307AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool IsUsingNameServer
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x30D2C0", Offset = "0x30B8C0", VA = "0x18030D2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x30D480", Offset = "0x30BA80", VA = "0x18030D480")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public string NameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x1307910", Offset = "0x1305F10", VA = "0x181307910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string CurrentServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x13077F0", Offset = "0x1305DF0", VA = "0x1813077F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string MasterServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x303590", Offset = "0x301B90", VA = "0x180303590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x3F76A0", Offset = "0x3F5CA0", VA = "0x1803F76A0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string GameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2FA780", Offset = "0x2F8D80", VA = "0x1802FA780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2FA7D0", Offset = "0x2F8DD0", VA = "0x1802FA7D0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public ServerConnection Server
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x668830", Offset = "0x666E30", VA = "0x180668830")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x668530", Offset = "0x666B30", VA = "0x180668530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public ClientState State
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xB22C70", Offset = "0xB21270", VA = "0x180B22C70")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x1307D20", Offset = "0x1306320", VA = "0x181307D20")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x13078F0", Offset = "0x1305EF0", VA = "0x1813078F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool IsConnectedAndReady
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x1307880", Offset = "0x1305E80", VA = "0x181307880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public DisconnectCause DisconnectedCause
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x4861B0", Offset = "0x4847B0", VA = "0x1804861B0")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x486770", Offset = "0x484D70", VA = "0x180486770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public TypedLobby CurrentLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x300D90", Offset = "0x2FF390", VA = "0x180300D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x300DC0", Offset = "0x2FF3C0", VA = "0x180300DC0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public bool AutoJoinLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x300D80", Offset = "0x2FF380", VA = "0x180300D80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x300DB0", Offset = "0x2FF3B0", VA = "0x180300DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x4843E0", Offset = "0x4829E0", VA = "0x1804843E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x34EE20", Offset = "0x34D420", VA = "0x18034EE20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Player LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x550290", Offset = "0x54E890", VA = "0x180550290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x34EDF0", Offset = "0x34D3F0", VA = "0x18034EDF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x1307AB0", Offset = "0x13060B0", VA = "0x181307AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x1307CF0", Offset = "0x13062F0", VA = "0x181307CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x1307B00", Offset = "0x1306100", VA = "0x181307B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x1307D70", Offset = "0x1306370", VA = "0x181307D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public int PlayersOnMasterCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x484430", Offset = "0x482A30", VA = "0x180484430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4844A0", Offset = "0x482AA0", VA = "0x1804844A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public int PlayersInRoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x5A0280", Offset = "0x59E880", VA = "0x1805A0280")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x5A02A0", Offset = "0x59E8A0", VA = "0x1805A02A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public int RoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x11BEFC0", Offset = "0x11BD5C0", VA = "0x1811BEFC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x1307D10", Offset = "0x1306310", VA = "0x181307D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public List<FriendInfo> FriendList
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF060", VA = "0x1805C0A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x33BAA0", Offset = "0x33A0A0", VA = "0x18033BAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public int FriendListAge
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x1307810", Offset = "0x1305E10", VA = "0x181307810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x1307850", Offset = "0x1305E50", VA = "0x181307850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public string[] AvailableRegions
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x5A0290", Offset = "0x59E890", VA = "0x1805A0290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x374300", Offset = "0x372900", VA = "0x180374300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public string[] AvailableRegionsServers
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x5A0270", Offset = "0x59E870", VA = "0x1805A0270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x6C4A50", Offset = "0x6C3050", VA = "0x1806C4A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public string CloudRegion
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x5C0A50", Offset = "0x5BF050", VA = "0x1805C0A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x3795C0", Offset = "0x377BC0", VA = "0x1803795C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x1307750", Offset = "0x1305D50", VA = "0x181307750")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x1307C50", Offset = "0x1306250", VA = "0x181307C50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x1307610", Offset = "0x1305C10", VA = "0x181307610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x1307B10", Offset = "0x1306110", VA = "0x181307B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x13076B0", Offset = "0x1305CB0", VA = "0x1813076B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1307BB0", Offset = "0x13061B0", VA = "0x181307BB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1307410", Offset = "0x1305A10", VA = "0x181307410")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x13073C0", Offset = "0x13059C0", VA = "0x1813073C0")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1303140", Offset = "0x1301740", VA = "0x181303140")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x13029E0", Offset = "0x1300FE0", VA = "0x1813029E0")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1302930", Offset = "0x1300F30", VA = "0x181302930", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x13026B0", Offset = "0x1300CB0", VA = "0x1813026B0")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x13027E0", Offset = "0x1300DE0", VA = "0x1813027E0")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1302E30", Offset = "0x1301430", VA = "0x181302E30")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1302340", Offset = "0x1300940", VA = "0x181302340")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1306FA0", Offset = "0x13055A0", VA = "0x181306FA0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1302D40", Offset = "0x1301340", VA = "0x181302D40")]
		private void DisconnectToReconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1302610", Offset = "0x1300C10", VA = "0x181302610")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1305890", Offset = "0x1303E90", VA = "0x181305890")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x1305580", Offset = "0x1303B80", VA = "0x181305580")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x13058E0", Offset = "0x1303EE0", VA = "0x1813058E0")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xF4FB70", Offset = "0xF4E170", VA = "0x180F4FB70")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1305AA0", Offset = "0x13040A0", VA = "0x181305AA0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1305B50", Offset = "0x1304150", VA = "0x181305B50")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1305C00", Offset = "0x1304200", VA = "0x181305C00")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x1305D90", Offset = "0x1304390", VA = "0x181305D90")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x13060C0", Offset = "0x13046C0", VA = "0x1813060C0")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1305990", Offset = "0x1303F90", VA = "0x181305990")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1305470", Offset = "0x1303A70", VA = "0x181305470")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1305E90", Offset = "0x1304490", VA = "0x181305E90")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1305F20", Offset = "0x1304520", VA = "0x181305F20")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1305860", Offset = "0x1303E60", VA = "0x181305860")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x13061B0", Offset = "0x13047B0", VA = "0x1813061B0")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1306480", Offset = "0x1304A80", VA = "0x181306480")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x13066C0", Offset = "0x1304CC0", VA = "0x1813066C0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1306530", Offset = "0x1304B30", VA = "0x181306530")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x13065D0", Offset = "0x1304BD0", VA = "0x1813065D0")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1306800", Offset = "0x1304E00", VA = "0x181306800")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1306090", Offset = "0x1304690", VA = "0x181306090", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1305FE0", Offset = "0x13045E0", VA = "0x181305FE0", Slot = "10")]
		[Obsolete]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1305450", Offset = "0x1303A50", VA = "0x181305450", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1306B40", Offset = "0x1305140", VA = "0x181306B40")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1306A40", Offset = "0x1305040", VA = "0x181306A40")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1302400", Offset = "0x1300A00", VA = "0x181302400")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1302570", Offset = "0x1300B70", VA = "0x181302570")]
		private void CleanCachedValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1302EB0", Offset = "0x13014B0", VA = "0x181302EB0")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x13071D0", Offset = "0x13057D0", VA = "0x1813071D0")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1302AA0", Offset = "0x13010A0", VA = "0x181302AA0", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1302B30", Offset = "0x1301130", VA = "0x181302B30", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1302C20", Offset = "0x1301220", VA = "0x181302C20", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1303E90", Offset = "0x1302490", VA = "0x181303E90", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1304D40", Offset = "0x1303340", VA = "0x181304D40", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1303310", Offset = "0x1301910", VA = "0x181303310", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1303E30", Offset = "0x1302430", VA = "0x181303E30", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1306FC0", Offset = "0x13055C0", VA = "0x181306FC0")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1306920", Offset = "0x1304F20", VA = "0x181306920")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private enum RoomOptionBit
		{
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			CheckUserOnJoin = 1,
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			DeleteCacheOnLeave = 2,
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			SuppressRoomEvents = 4,
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			PublishUserId = 8,
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			DeleteNullProps = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		protected internal static Type PingImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private readonly Dictionary<byte, object> opParameters;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x130B950", Offset = "0x1309F50", VA = "0x18130B950")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x130B860", Offset = "0x1309E60", VA = "0x18130B860")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x1309500", Offset = "0x1307B00", VA = "0x181309500")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x130A210", Offset = "0x1308810", VA = "0x18130A210", Slot = "15")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x130A2E0", Offset = "0x13088E0", VA = "0x18130A2E0", Slot = "16")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x130A9A0", Offset = "0x1308FA0", VA = "0x18130A9A0", Slot = "17")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x130B480", Offset = "0x1309A80", VA = "0x18130B480")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1309D30", Offset = "0x1308330", VA = "0x181309D30", Slot = "18")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x130A6F0", Offset = "0x1308CF0", VA = "0x18130A6F0", Slot = "19")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x130A430", Offset = "0x1308A30", VA = "0x18130A430", Slot = "20")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x130AA50", Offset = "0x1309050", VA = "0x18130AA50", Slot = "21")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x130A040", Offset = "0x1308640", VA = "0x18130A040", Slot = "22")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x1309F70", Offset = "0x1308570", VA = "0x181309F70", Slot = "23")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x130AE10", Offset = "0x1309410", VA = "0x18130AE10")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x130AE90", Offset = "0x1309490", VA = "0x18130AE90")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x130B260", Offset = "0x1309860", VA = "0x18130B260")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x130AE50", Offset = "0x1309450", VA = "0x18130AE50")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x130B0C0", Offset = "0x13096C0", VA = "0x18130B0C0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1309970", Offset = "0x1307F70", VA = "0x181309970", Slot = "24")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x13096B0", Offset = "0x1307CB0", VA = "0x1813096B0", Slot = "25")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1309C00", Offset = "0x1308200", VA = "0x181309C00", Slot = "26")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x130AB80", Offset = "0x1309180", VA = "0x18130AB80", Slot = "27")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x130B320", Offset = "0x1309920", VA = "0x18130B320", Slot = "28")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class OpJoinRandomRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public Hashtable ExpectedCustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public byte ExpectedMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public MatchmakingMode MatchingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public TypedLobby TypedLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public string SqlLobbyFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class EnterRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public RoomOptions RoomOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public TypedLobby Lobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public Hashtable PlayerProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public bool OnGameServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public bool CreateIfNotExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public bool RejoinOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x77C580", Offset = "0x77AB80", VA = "0x18077C580")]
		public EnterRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public const int Ok = 0;

		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[Obsolete]
		public const int InvalidOperationCode = -2;

		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public const int InvalidOperation = -2;

		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public const int InternalServerError = -1;

		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public const int InvalidAuthentication = 32767;

		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public const int GameIdAlreadyExists = 32766;

		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public const int GameFull = 32765;

		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public const int GameClosed = 32764;

		[Cpp2IlInjected.Token(Token = "0x400026D")]
		[Obsolete]
		public const int AlreadyMatched = 32763;

		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public const int ServerFull = 32762;

		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public const int UserBlocked = 32761;

		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public const int NoRandomMatchFound = 32760;

		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public const int GameDoesNotExist = 32758;

		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public const int MaxCcuReached = 32757;

		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public const int InvalidRegion = 32756;

		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public const int CustomAuthenticationFailed = 32755;

		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public const int AuthenticationTicketExpired = 32753;

		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public const int PluginReportedError = 32752;

		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public const int PluginMismatch = 32751;

		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public const int HttpLimitReached = 32745;

		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public const int ExternalHttpCallFailed = 32744;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const int SlotError = 32742;

		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public const int InvalidEncryptionParameters = 32741;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public ErrorCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class ActorProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public const byte PlayerName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public const byte IsInactive = 254;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public const byte UserId = 253;

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public ActorProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class GamePropertyKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public const byte MaxPlayers = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public const byte IsVisible = 254;

		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public const byte IsOpen = 253;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const byte PlayerCount = 252;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public const byte Removed = 251;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const byte PropsListedInLobby = 250;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public const byte CleanupCacheOnLeave = 249;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const byte MasterClientId = 248;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public const byte ExpectedUsers = 247;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public GamePropertyKey()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class EventCode
	{
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public const byte GameList = 230;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public const byte GameListUpdate = 229;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const byte QueueState = 228;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public const byte Match = 227;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public const byte AppStats = 226;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const byte LobbyStats = 224;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const byte PropertiesChanged = 253;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		[Obsolete]
		public const byte SetProperties = 253;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const byte ErrorInfo = 251;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const byte CacheSliceChanged = 250;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const byte AuthEvent = 223;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public EventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class ParameterCode
	{
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const byte SuppressRoomEvents = 237;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const byte EmptyRoomTTL = 236;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const byte PlayerTTL = 235;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const byte EventForward = 234;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[Obsolete]
		public const byte IsComingBack = 233;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const byte IsInactive = 233;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const byte CheckUserOnJoin = 232;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const byte ExpectedValues = 231;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const byte Address = 230;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public const byte PeerCount = 229;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const byte GameCount = 228;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public const byte MasterPeerCount = 227;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public const byte UserId = 225;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public const byte ApplicationId = 224;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public const byte Position = 223;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public const byte MatchMakingType = 223;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public const byte GameList = 222;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const byte Secret = 221;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public const byte AppVersion = 220;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[Obsolete]
		public const byte AzureLocalNodeId = 209;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[Obsolete]
		public const byte AzureMasterNodeId = 208;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public const byte RoomName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public const byte Broadcast = 250;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public const byte ActorList = 252;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public const byte ActorNr = 254;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public const byte PlayerProperties = 249;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public const byte CustomEventContent = 245;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public const byte Data = 245;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public const byte Code = 244;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public const byte GameProperties = 248;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public const byte Properties = 251;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public const byte TargetActorNr = 253;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public const byte ReceiverGroup = 246;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public const byte Cache = 247;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public const byte CleanupCacheOnLeave = 241;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public const byte Group = 240;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public const byte Remove = 239;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public const byte PublishUserId = 239;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public const byte Add = 238;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public const byte Info = 218;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public const byte ClientAuthenticationType = 217;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public const byte ClientAuthenticationParams = 216;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public const byte JoinMode = 215;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public const byte ClientAuthenticationData = 214;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public const byte MasterClientId = 203;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public const byte FindFriendsRequestList = 1;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public const byte LobbyName = 213;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public const byte LobbyType = 212;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const byte LobbyStats = 211;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public const byte Region = 210;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public const byte UriPath = 209;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const byte WebRpcParameters = 208;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public const byte WebRpcReturnCode = 207;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public const byte WebRpcReturnMessage = 206;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public const byte CacheSliceIndex = 205;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public const byte Plugins = 204;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public const byte NickName = 202;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public const byte PluginName = 201;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public const byte PluginVersion = 200;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public const byte ExpectedProtocol = 195;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const byte CustomInitData = 194;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public const byte EncryptionMode = 193;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const byte EncryptionData = 192;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public const byte RoomOptionFlags = 191;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public ParameterCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class OperationCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public const byte AuthenticateOnce = 231;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public const byte Authenticate = 230;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public const byte JoinLobby = 229;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public const byte LeaveLobby = 228;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const byte CreateGame = 227;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public const byte JoinGame = 226;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const byte JoinRandomGame = 225;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const byte RaiseEvent = 253;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public const byte SetProperties = 252;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public const byte GetProperties = 251;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public const byte ChangeGroups = 248;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public const byte FindFriends = 222;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const byte GetLobbyStats = 221;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const byte GetRegions = 220;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const byte WebRpc = 219;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public const byte ServerSettings = 218;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public const byte GetGameList = 217;

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F8270", VA = "0x1802F9C70")]
		public OperationCode()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public enum JoinMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		CreateIfNotExists,
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		JoinOrRejoin,
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		RejoinOnly
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public enum MatchmakingMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		FillRoom,
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		SerialMatching,
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		RandomMatching
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public enum ReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		All,
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		MasterClient
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public enum EventCaching : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[Obsolete]
		MergeCache = 1,
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[Obsolete]
		ReplaceCache = 2,
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[Obsolete]
		RemoveCache = 3,
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		SliceIncreaseIndex = 10,
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		SliceSetIndex = 11,
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		SlicePurgeIndex = 12,
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		SlicePurgeUpToIndex = 13
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		Game = 1,
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		Actor = 2,
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		GameAndActor = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class RoomOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public byte MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int PlayerTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public int EmptyRoomTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private bool cleanupCacheOnLeave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public Hashtable CustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public string[] CustomRoomPropertiesForLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public string[] Plugins;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x338520", Offset = "0x336B20", VA = "0x180338520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x2E4260", Offset = "0x2E2860", VA = "0x1802E4260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x3F8AA0", Offset = "0x3F70A0", VA = "0x1803F8AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x5C2770", Offset = "0x5C0D70", VA = "0x1805C2770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool CleanupCacheOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x538CE0", Offset = "0x5372E0", VA = "0x180538CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x769C40", Offset = "0x768240", VA = "0x180769C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool SuppressRoomEvents
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x30D1D0", Offset = "0x30B7D0", VA = "0x18030D1D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x30D380", Offset = "0x30B980", VA = "0x18030D380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public bool PublishUserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x30D2C0", Offset = "0x30B8C0", VA = "0x18030D2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x30D480", Offset = "0x30BA80", VA = "0x18030D480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool DeleteNullProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x769C20", Offset = "0x768220", VA = "0x180769C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x4B2E60", Offset = "0x4B1460", VA = "0x1804B2E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1310C80", Offset = "0x130F280", VA = "0x181310C80")]
		public RoomOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class RaiseEventOptions
	{
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public static readonly RaiseEventOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public EventCaching CachingOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public byte InterestGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int[] TargetActors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public ReceiverGroup Receivers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[Obsolete]
		public byte SequenceChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public WebFlags Flags;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x130E1D0", Offset = "0x130C7D0", VA = "0x18130E1D0")]
		public RaiseEventOptions()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public enum LobbyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		SqlLobby = 2,
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		AsyncRandomLobby = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public LobbyType Type;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public static readonly TypedLobby Default;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xBD7540", Offset = "0xBD5B40", VA = "0x180BD7540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x13150C0", Offset = "0x13136C0", VA = "0x1813150C0")]
		public TypedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x3374E0", Offset = "0x335AE0", VA = "0x1803374E0")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x1314FC0", Offset = "0x13135C0", VA = "0x181314FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int PlayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int RoomCount;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1314D30", Offset = "0x1313330", VA = "0x181314D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1314F30", Offset = "0x1313530", VA = "0x181314F30")]
		public TypedLobbyInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public enum AuthModeOption
	{
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		AuthOnce,
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		AuthOnceWss
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public enum CustomAuthenticationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		Facebook = 2,
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		Oculus = 3,
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		Xbox = 5,
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		None = byte.MaxValue
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class AuthenticationValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private CustomAuthenticationType authType;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public CustomAuthenticationType AuthType
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x338520", Offset = "0x336B20", VA = "0x180338520")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x2E4260", Offset = "0x2E2860", VA = "0x1802E4260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public string AuthGetParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x302B80", VA = "0x180304580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public object AuthPostData
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public string Token
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA40", Offset = "0x2FA040", VA = "0x1802FBA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA50", Offset = "0x2FA050", VA = "0x1802FBA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xC63CB0", Offset = "0xC622B0", VA = "0x180C63CB0")]
		public AuthenticationValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xC63C80", Offset = "0xC62280", VA = "0x180C63C80")]
		public AuthenticationValues(string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xC63BC0", Offset = "0xC621C0", VA = "0x180C63BC0", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x12FF570", Offset = "0x12FDB70", VA = "0x1812FF570", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x12FF7A0", Offset = "0x12FDDA0", VA = "0x1812FF7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public abstract class PhotonPing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public string DebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public bool Successful;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected internal bool GotResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected internal int PingLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected internal byte[] PingBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected internal byte PingId;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x130D010", Offset = "0x130B610", VA = "0x18130D010", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x130CFC0", Offset = "0x130B5C0", VA = "0x18130CFC0", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x130CF70", Offset = "0x130B570", VA = "0x18130CF70", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xC25150", Offset = "0xC23750", VA = "0x180C25150")]
		protected internal void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x130D060", Offset = "0x130B660", VA = "0x18130D060")]
		protected PhotonPing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class PingMono : PhotonPing
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private Socket sock;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x130D270", Offset = "0x130B870", VA = "0x18130D270", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x130D140", Offset = "0x130B740", VA = "0x18130D140", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x130D0E0", Offset = "0x130B6E0", VA = "0x18130D0E0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x130D060", Offset = "0x130B660", VA = "0x18130D060")]
		public PingMono()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class Player
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private int actorID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public readonly bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private string nickName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public object TagObject;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		protected internal Room RoomReference
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x130E0B0", Offset = "0x130C6B0", VA = "0x18130E0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x130E090", Offset = "0x130C690", VA = "0x18130E090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public bool IsInactive
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2E61D0", Offset = "0x2E47D0", VA = "0x1802E61D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x308F40", Offset = "0x307540", VA = "0x180308F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x2E98B0", Offset = "0x2E7EB0", VA = "0x1802E98B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x2E9160", Offset = "0x2E7760", VA = "0x1802E9160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public Hashtable AllProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x130DFF0", Offset = "0x130C5F0", VA = "0x18130DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x130DFD0", Offset = "0x130C5D0", VA = "0x18130DFD0")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x130DEE0", Offset = "0x130C4E0", VA = "0x18130DEE0")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x130D7C0", Offset = "0x130BDC0", VA = "0x18130D7C0")]
		public Player Get(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x130D7B0", Offset = "0x130BDB0", VA = "0x18130D7B0")]
		public Player GetNext()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x130D790", Offset = "0x130BD90", VA = "0x18130D790")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x130D570", Offset = "0x130BB70", VA = "0x18130D570")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x130D7E0", Offset = "0x130BDE0", VA = "0x18130D7E0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x130DE60", Offset = "0x130C460", VA = "0x18130DE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x130DC10", Offset = "0x130C210", VA = "0x18130DC10")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x130D4A0", Offset = "0x130BAA0", VA = "0x18130D4A0", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x130D490", Offset = "0x130BA90", VA = "0x18130D490")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x130DA40", Offset = "0x130C040", VA = "0x18130DA40")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x130DB40", Offset = "0x130C140", VA = "0x18130DB40")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class Room : RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected internal int PlayerTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected internal int RoomTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private Dictionary<int, Player> players;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x2FA7B0", Offset = "0x2F8DB0", VA = "0x1802FA7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x372A30", Offset = "0x371030", VA = "0x180372A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public new string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x2E98B0", Offset = "0x2E7EB0", VA = "0x1802E98B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x2E9160", Offset = "0x2E7760", VA = "0x1802E9160")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public new bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x2E61D0", Offset = "0x2E47D0", VA = "0x1802E61D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x1311A10", Offset = "0x1310010", VA = "0x181311A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public new bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x2E61F0", Offset = "0x2E47F0", VA = "0x1802E61F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x1311B30", Offset = "0x1310130", VA = "0x181311B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public new byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x30C4C0", Offset = "0x30AAC0", VA = "0x18030C4C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x1311C50", Offset = "0x1310250", VA = "0x181311C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public new byte PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x13119C0", Offset = "0x130FFC0", VA = "0x1813119C0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public Dictionary<int, Player> Players
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x305DB0", Offset = "0x3043B0", VA = "0x180305DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x5B8990", Offset = "0x5B6F90", VA = "0x1805B8990")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public string[] ExpectedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int MasterClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x350930", Offset = "0x34EF30", VA = "0x180350930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public string[] PropertiesListedInLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x305D40", Offset = "0x304340", VA = "0x180305D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x3AF6B0", Offset = "0x3ADCB0", VA = "0x1803AF6B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public bool AutoCleanUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x308D00", Offset = "0x307300", VA = "0x180308D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1311900", Offset = "0x130FF00", VA = "0x181311900")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1310F90", Offset = "0x130F590", VA = "0x181310F90", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x13111E0", Offset = "0x130F7E0", VA = "0x1813111E0")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1310F20", Offset = "0x130F520", VA = "0x181310F20", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1310EE0", Offset = "0x130F4E0", VA = "0x181310EE0", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1311060", Offset = "0x130F660", VA = "0x181311060")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1310CD0", Offset = "0x130F2D0", VA = "0x181310CD0", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x13112A0", Offset = "0x130F8A0", VA = "0x1813112A0", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1310E70", Offset = "0x130F470", VA = "0x181310E70", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1310D60", Offset = "0x130F360", VA = "0x181310D60")]
		public void ClearExpectedUsers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1311660", Offset = "0x130FC60", VA = "0x181311660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1311320", Offset = "0x130F920", VA = "0x181311320")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		protected internal bool removedFromList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private Hashtable customProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected byte maxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		protected string[] expectedUsers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		protected bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		protected bool autoCleanUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected internal int masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected string[] propertiesListedInLobby;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x300910", VA = "0x180302310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x2E98B0", Offset = "0x2E7EB0", VA = "0x1802E98B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public int PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x2FA790", Offset = "0x2F8D90", VA = "0x1802FA790")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x2FA7E0", Offset = "0x2F8DE0", VA = "0x1802FA7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public bool IsLocalClientInside
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x769B70", Offset = "0x768170", VA = "0x180769B70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x769B80", Offset = "0x768180", VA = "0x180769B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x30C4C0", Offset = "0x30AAC0", VA = "0x18030C4C0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x2E61D0", Offset = "0x2E47D0", VA = "0x1802E61D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x2E61F0", Offset = "0x2E47F0", VA = "0x1802E61F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1310BE0", Offset = "0x130F1E0", VA = "0x181310BE0")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1310040", Offset = "0x130E640", VA = "0x181310040", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x13100E0", Offset = "0x130E6E0", VA = "0x1813100E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1310970", Offset = "0x130EF70", VA = "0x181310970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1310660", Offset = "0x130EC60", VA = "0x181310660")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x1310110", Offset = "0x130E710", VA = "0x181310110", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class WebRpcResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x2E92D0", Offset = "0x2E78D0", VA = "0x1802E92D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x2F6450", Offset = "0x2F4A50", VA = "0x1802F6450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public int ReturnCode
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x2E92E0", Offset = "0x2E78E0", VA = "0x1802E92E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x32A5A0", Offset = "0x328BA0", VA = "0x18032A5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public string DebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x2FFED0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x337AA0", VA = "0x1803394A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x2EA5A0", Offset = "0x2E8BA0", VA = "0x1802EA5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x2EBAA0", Offset = "0x2EA0A0", VA = "0x1802EBAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1316360", Offset = "0x1314960", VA = "0x181316360")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1316150", Offset = "0x1314750", VA = "0x181316150")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class WebFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public static readonly WebFlags Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public byte WebhookFlags;

		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public const byte HttpForwardConst = 1;

		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public const byte SendAuthCookieConst = 2;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public const byte SendSyncConst = 4;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public const byte SendStateConst = 8;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public bool HttpForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x1316050", Offset = "0x1314650", VA = "0x181316050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x1316090", Offset = "0x1314690", VA = "0x181316090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool SendAuthCookie
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x1316060", Offset = "0x1314660", VA = "0x181316060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x13160C0", Offset = "0x13146C0", VA = "0x1813160C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public bool SendSync
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x1316080", Offset = "0x1314680", VA = "0x181316080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x1316120", Offset = "0x1314720", VA = "0x181316120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool SendState
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x1316070", Offset = "0x1314670", VA = "0x181316070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x13160F0", Offset = "0x13146F0", VA = "0x1813160F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x913930", Offset = "0x911F30", VA = "0x180913930")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
