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
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class DataCallback : AndroidJavaProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private Action<short[]> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private IntPtr javaBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private int cntFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private int cntShort;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1596BA0", Offset = "0x15957A0", VA = "0x181596BA0")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x1596B20", Offset = "0x1595720", VA = "0x181596B20")]
		public void OnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1596B90", Offset = "0x1595790", VA = "0x181596B90")]
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

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const int SAMPLING_RATE = 44100;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E8550", Offset = "0x6E7150", VA = "0x1806E8550", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1593520", Offset = "0x1592120", VA = "0x181593520", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
	public AndroidAudioInAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1592A50", Offset = "0x1591650", VA = "0x181592A50", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15929F0", Offset = "0x15915F0", VA = "0x1815929F0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MonoPInvokeCallbackAttribute : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Type type;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4CF7F0", Offset = "0x4CE3F0", VA = "0x1804CF7F0")]
	public MonoPInvokeCallbackAttribute(Type t)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AppleAudioInPusher : IAudioPusher<float>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private delegate void CallbackDelegate(int instanceID, IntPtr buf, int len);

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const string lib_name = "AudioIn";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int deviceID;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static int instanceCnt;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Dictionary<int, AppleAudioInPusher> instancePerHandle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private IntPtr handle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Action<float[]> pushCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LocalVoiceFramed<float> localVoice;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const int SAMPLING_RATE = 48000;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8550", Offset = "0x6E7150", VA = "0x1806E8550", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1593A90", Offset = "0x1592690", VA = "0x181593A90", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1593610", Offset = "0x1592210", VA = "0x181593610")]
	private static extern IntPtr Photon_Audio_In_CreatePusher(int instanceID, int deviceID, Action<int, IntPtr, int> pushCallback);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15936D0", Offset = "0x15922D0", VA = "0x1815936D0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x333DE0", Offset = "0x3329E0", VA = "0x180333DE0")]
	public AppleAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1593AA0", Offset = "0x15926A0", VA = "0x181593AA0")]
	[MonoPInvokeCallback(typeof(CallbackDelegate))]
	private static void nativePushCallback(int instanceID, IntPtr buf, int len)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1593770", Offset = "0x1592370", VA = "0x181593770", Slot = "4")]
	public void SetCallback(Action<float[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1593C70", Offset = "0x1592870", VA = "0x181593C70")]
	private void push(IntPtr buf, int len)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1593530", Offset = "0x1592130", VA = "0x181593530", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AudioClip audioClip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int readPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private float startTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool playing;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool Loop
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x31A530", Offset = "0x319130", VA = "0x18031A530")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x393280", Offset = "0x391E80", VA = "0x180393280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x102A720", Offset = "0x1029320", VA = "0x18102A720", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x102A700", Offset = "0x1029300", VA = "0x18102A700", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1593EE0", Offset = "0x1592AE0", VA = "0x181593EE0")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1593DB0", Offset = "0x15929B0", VA = "0x181593DB0", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AudioOutCapture : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15948B0", Offset = "0x15934B0", VA = "0x1815948B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1594950", Offset = "0x1593550", VA = "0x181594950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1594850", Offset = "0x1593450", VA = "0x181594850")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public AudioOutCapture()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AudioStreamPlayer : IAudioOut
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private const int maxPlayLagMs = 100;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int maxPlayLagSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int playDelaySamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int bufferSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int channels;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int frameSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int frameSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private int streamSamplePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int streamSamplePosAvg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private AudioSource source;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string logPrefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private bool debugInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int sourceTimeSamplesPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int playLoopCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<float[]> frameQueue;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PrimitiveArrayPool<float> framePool;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CurrentBufferLag
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x44C770", Offset = "0x44B370", VA = "0x18044C770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x44C780", Offset = "0x44B380", VA = "0x18044C780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AudioSource AudioSource
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x322020", Offset = "0x320C20", VA = "0x180322020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int playSamplePos
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1595900", Offset = "0x1594500", VA = "0x181595900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x15959C0", Offset = "0x15945C0", VA = "0x1815959C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x15958E0", Offset = "0x15944E0", VA = "0x1815958E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1595810", Offset = "0x1594410", VA = "0x181595810")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1595660", Offset = "0x1594260", VA = "0x181595660", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1594D50", Offset = "0x1593950", VA = "0x181594D50", Slot = "8")]
	public void Service()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15949F0", Offset = "0x15935F0", VA = "0x1815949F0", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x15957D0", Offset = "0x15943D0", VA = "0x1815957D0", Slot = "6")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1594CD0", Offset = "0x15938D0", VA = "0x181594CD0", Slot = "10")]
	public void Pause()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730")]
	private void PhotonVoiceCreated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private AudioClip mic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int micPrevPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private int micLoopCnt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int readAbsPos;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x102A720", Offset = "0x1029320", VA = "0x18102A720", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x102A700", Offset = "0x1029300", VA = "0x18102A700", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x102A650", Offset = "0x1029250", VA = "0x18102A650")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x102A530", Offset = "0x1029130", VA = "0x18102A530", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x102A540", Offset = "0x1029140", VA = "0x18102A540", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class WindowsAudioInPusher : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private enum SystemMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		SINGLE_CHANNEL_AEC = 0,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		OPTIBEAM_ARRAY_ONLY = 2,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		OPTIBEAM_ARRAY_AND_AEC = 4,
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		SINGLE_CHANNEL_NSAGC = 5
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IntPtr handle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Action<short[]> pushCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private LocalVoiceFramed<short> localVoice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private int deviceID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Action<IntPtr, int> pushRef;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E8550", Offset = "0x6E7150", VA = "0x1806E8550", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x24204E0", Offset = "0x241F0E0", VA = "0x1824204E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24200B0", Offset = "0x241ECB0", VA = "0x1824200B0")]
	private static extern IntPtr Photon_Audio_In_Create(SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24201C0", Offset = "0x241EDC0", VA = "0x1824201C0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24204B0", Offset = "0x241F0B0", VA = "0x1824204B0")]
	public WindowsAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2420260", Offset = "0x241EE60", VA = "0x182420260", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24204F0", Offset = "0x241F0F0", VA = "0x1824204F0")]
	private void push(IntPtr buf, int lenBytes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2420010", Offset = "0x241EC10", VA = "0x182420010", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class SA_PD_EditorIcons
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x241E2D0", Offset = "0x241CED0", VA = "0x18241E2D0")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	Error
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ASIdentifierManagerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[SerializeField]
	private Text advertisingTrackingEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[SerializeField]
	private Text advertisingIdentifier;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x15928C0", Offset = "0x15914C0", VA = "0x1815928C0")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1592950", Offset = "0x1591550", VA = "0x181592950")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1021080", Offset = "0x101FC80", VA = "0x181021080")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1021810", Offset = "0x1020410", VA = "0x181021810", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1021A10", Offset = "0x1020610", VA = "0x181021A10", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1021890", Offset = "0x1020490", VA = "0x181021890", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1021900", Offset = "0x1020500", VA = "0x181021900", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1021970", Offset = "0x1020570", VA = "0x181021970", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x10219C0", Offset = "0x10205C0", VA = "0x1810219C0", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1021E60", Offset = "0x1020A60", VA = "0x181021E60")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
	public ISN_CoreLocationDelegateExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ISN_CoreLocationUseExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[SerializeField]
	private Button m_AuthButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[SerializeField]
	private Button m_StartUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[SerializeField]
	private Button m_StopUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[SerializeField]
	private Button m_RequestLocationButton;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1022120", Offset = "0x1020D20", VA = "0x181022120")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1021FC0", Offset = "0x1020BC0", VA = "0x181021FC0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_CoreLocationUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ISN_EventKitExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[SerializeField]
	private Text m_Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private string m_EventID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private string m_ReminderID;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1022B20", Offset = "0x1021720", VA = "0x181022B20")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1022BB0", Offset = "0x10217B0", VA = "0x181022BB0")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x10226D0", Offset = "0x10212D0", VA = "0x1810226D0")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1022980", Offset = "0x1021580", VA = "0x181022980")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1022820", Offset = "0x1021420", VA = "0x181022820")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1022A50", Offset = "0x1021650", VA = "0x181022A50")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_EventKitExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ISN_GameKitUseExample_TvOS : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[SerializeField]
	private Button m_SingInButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[SerializeField]
	private Button m_LeaderboardsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[SerializeField]
	private Button m_AchievementsUI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1023370", Offset = "0x1021F70", VA = "0x181023370")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_GameKitUseExample_TvOS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1596D40", Offset = "0x1595940", VA = "0x181596D40")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public DocumentationExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ISN_MediaPlayerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[SerializeField]
	[Header("Info Panel")]
	private Text m_title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[SerializeField]
	private Text m_artist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[SerializeField]
	private Text m_playbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[SerializeField]
	[Header("Buttons")]
	private Button m_play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[SerializeField]
	private Button m_stop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[SerializeField]
	private Button m_pause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[SerializeField]
	private Button m_next;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[SerializeField]
	private Button m_previos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private ISN_MPMusicPlayerController m_player;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x10241F0", Offset = "0x1022DF0", VA = "0x1810241F0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1024580", Offset = "0x1023180", VA = "0x181024580")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_MediaPlayerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ISN_CameraGalleryExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[SerializeField]
	private Button m_loadFromGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[SerializeField]
	private Button m_loadFromCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[SerializeField]
	private Button m_saveToGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[SerializeField]
	private Image m_image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[SerializeField]
	private GameObject m_go;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1021360", Offset = "0x101FF60", VA = "0x181021360")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_CameraGalleryExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ISN_SocialExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[SerializeField]
	private Button m_twitterText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[SerializeField]
	private Button m_twitterTextImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[SerializeField]
	private Button m_fbImage;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x10258A0", Offset = "0x10244A0", VA = "0x1810258A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_SocialExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ISN_UIImagePickerControllerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[SerializeField]
	private RawImage m_Image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[SerializeField]
	private Image m_Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[SerializeField]
	[Header("Image")]
	private Button m_ImageCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[SerializeField]
	private Button m_ImageLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[SerializeField]
	private Button m_ImageAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[SerializeField]
	[Header("Video")]
	private Button m_VideoCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[SerializeField]
	private Button m_VideoLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	private Button m_VideoAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	private Button m_VideoPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ISN_UIPickerControllerResult m_LastPickerResult;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1026520", Offset = "0x1025120", VA = "0x181026520")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1026390", Offset = "0x1024F90", VA = "0x181026390")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1026F40", Offset = "0x1025B40", VA = "0x181026F40")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1026B70", Offset = "0x1025770", VA = "0x181026B70")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x10269C0", Offset = "0x10255C0", VA = "0x1810269C0")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1026400", Offset = "0x1025000", VA = "0x181026400")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x10268A0", Offset = "0x10254A0", VA = "0x1810268A0")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
namespace SA.iOS.Tests.UserNotifications
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_RemoteNotifications_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x241C3A0", Offset = "0x241AFA0", VA = "0x18241C3A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x241CFB0", Offset = "0x241BBB0", VA = "0x18241CFB0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_UNAuthorization_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_UNSchedule_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x241D090", Offset = "0x241BC90", VA = "0x18241D090", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x241D440", Offset = "0x241C040", VA = "0x18241D440")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_UNSchedule_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.UIKit
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ISN_UIImagePickerController_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x241CB20", Offset = "0x241B720", VA = "0x18241CB20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x241C9F0", Offset = "0x241B5F0", VA = "0x18241C9F0")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x241EE10", Offset = "0x241DA10", VA = "0x18241EE10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public SaveToCameraRollTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Social
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_DefaultSharingDialog_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x241A900", Offset = "0x2419500", VA = "0x18241A900", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x241ABD0", Offset = "0x24197D0", VA = "0x18241ABD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x241C0E0", Offset = "0x241ACE0", VA = "0x18241C0E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x241C1F0", Offset = "0x241ADF0", VA = "0x18241C1F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x241C5A0", Offset = "0x241B1A0", VA = "0x18241C5A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x241C8E0", Offset = "0x241B4E0", VA = "0x18241C8E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x241D650", Offset = "0x241C250", VA = "0x18241D650", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_WhatsAppShare_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.GameKit
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ISN_GKAchievementsLoad_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x241ACF0", Offset = "0x24198F0", VA = "0x18241ACF0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x241B120", Offset = "0x2419D20", VA = "0x18241B120", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x241B040", Offset = "0x2419C40", VA = "0x18241B040")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x241AFD0", Offset = "0x2419BD0", VA = "0x18241AFD0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x241B3E0", Offset = "0x2419FE0", VA = "0x18241B3E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x241B370", Offset = "0x2419F70", VA = "0x18241B370")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x241B5A0", Offset = "0x241A1A0", VA = "0x18241B5A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x241B5D0", Offset = "0x241A1D0", VA = "0x18241B5D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x241B7E0", Offset = "0x241A3E0", VA = "0x18241B7E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x241BA60", Offset = "0x241A660", VA = "0x18241BA60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x241BC80", Offset = "0x241A880", VA = "0x18241BC80", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x241BE30", Offset = "0x241AA30", VA = "0x18241BE30", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x241BF90", Offset = "0x241AB90", VA = "0x18241BF90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		protected ISN_GKSingleLeaderboard_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_AudioSessionTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x241A110", Offset = "0x2418D10", VA = "0x18241A110", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x241A180", Offset = "0x2418D80", VA = "0x18241A180", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x241D6F0", Offset = "0x241C2F0", VA = "0x18241D6F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x241C320", Offset = "0x241AF20", VA = "0x18241C320", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x241C6C0", Offset = "0x241B2C0", VA = "0x18241C6C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_TimeZoneTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Contacts
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ISN_CNContactsPicker_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x241A230", Offset = "0x2418E30", VA = "0x18241A230", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x241A7D0", Offset = "0x24193D0", VA = "0x18241A7D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x241A300", Offset = "0x2418F00", VA = "0x18241A300")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x241A170", Offset = "0x2418D70", VA = "0x18241A170")]
		public ISN_CNFetchPhoneContacts_Test()
		{
		}
	}
}
namespace SA.iOS.Examples
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AVKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x101E850", Offset = "0x101D450", VA = "0x18101E850")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
		public AVKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class ISN_BaseIOSFeaturePreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected GUIStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		protected int buttonWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		protected int buttonHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		protected float StartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		protected float StartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		protected float XStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		protected float YStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		protected float XButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		protected float YButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		protected float YLableStep;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1021200", Offset = "0x101FE00", VA = "0x181021200", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9AEC80", Offset = "0x9AD880", VA = "0x1809AEC80", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1021300", Offset = "0x101FF00", VA = "0x181021300")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x10212F0", Offset = "0x101FEF0", VA = "0x1810212F0")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1021310", Offset = "0x101FF10", VA = "0x181021310")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1023240", Offset = "0x1021E40", VA = "0x181023240")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public ISN_FoundationExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class GameKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private List<ISN_GKSavedGame> m_fetchedSavedGames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private List<string> m_conflictedSavedGames;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x101EBB0", Offset = "0x101D7B0", VA = "0x18101EBB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x101F4E0", Offset = "0x101E0E0", VA = "0x18101F4E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x101EC90", Offset = "0x101D890", VA = "0x18101EC90")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x101EFC0", Offset = "0x101DBC0", VA = "0x18101EFC0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x101F5C0", Offset = "0x101E1C0", VA = "0x18101F5C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1021000", Offset = "0x101FC00", VA = "0x181021000")]
		public GameKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class iCloudUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private float valueF;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2420640", Offset = "0x241F240", VA = "0x182420640")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2420730", Offset = "0x241F330", VA = "0x182420730")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2421120", Offset = "0x241FD20", VA = "0x182421120")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x24207C0", Offset = "0x241F3C0", VA = "0x1824207C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24213A0", Offset = "0x241FFA0", VA = "0x1824213A0")]
		public iCloudUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ISN_UIController : SA_UIController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public ScrollRect scroll;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1025BF0", Offset = "0x10247F0", VA = "0x181025BF0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x1026100", Offset = "0x1024D00", VA = "0x181026100")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1025E90", Offset = "0x1024A90", VA = "0x181025E90", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x10260E0", Offset = "0x1024CE0", VA = "0x1810260E0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x10262B0", Offset = "0x1024EB0", VA = "0x1810262B0", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1026020", Offset = "0x1024C20", VA = "0x181026020", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1026200", Offset = "0x1024E00", VA = "0x181026200", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1025B40", Offset = "0x1024740", VA = "0x181025B40", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x336C90", Offset = "0x335890", VA = "0x180336C90")]
		public ISN_UIController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class SA_ExampleSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public List<SA_ExampleServicesConfig> Services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Sprite Logo;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x241D7B0", Offset = "0x241C3B0", VA = "0x18241D7B0")]
		public SA_ExampleSceneConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SA_ExampleSceneController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private SA_ExampleSceneConfig m_config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private SA_UIController m_UIController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<GameObject> m_links;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x241DE90", Offset = "0x241CA90", VA = "0x18241DE90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x241E030", Offset = "0x241CC30", VA = "0x18241E030")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x241DE50", Offset = "0x241CA50", VA = "0x18241DE50")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x241D840", Offset = "0x241C440", VA = "0x18241D840")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x241DB50", Offset = "0x241C750", VA = "0x18241DB50")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x241DA10", Offset = "0x241C610", VA = "0x18241DA10")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x241DC00", Offset = "0x241C800", VA = "0x18241DC00")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x241E1A0", Offset = "0x241CDA0", VA = "0x18241E1A0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x241DD00", Offset = "0x241C900", VA = "0x18241DD00")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x241D810", Offset = "0x241C410", VA = "0x18241D810")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x241E210", Offset = "0x241CE10", VA = "0x18241E210")]
		public SA_ExampleSceneController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class SA_ExampleServicesConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Sprite Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public List<SA_ExampleSubsectionConfig> Subsections;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x241E270", Offset = "0x241CE70", VA = "0x18241E270")]
		public SA_ExampleServicesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class SA_ExampleSubsectionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public SA_SceneField Scene;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public SA_ExampleSubsectionConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SA_SceneField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private UnityEngine.Object sceneAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private string sceneName;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x241E7E0", Offset = "0x241D3E0", VA = "0x18241E7E0")]
		public SA_SceneField()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class SA_SideToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[HideInInspector]
		public Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x241E950", Offset = "0x241D550", VA = "0x18241E950")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x241E820", Offset = "0x241D420", VA = "0x18241E820", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x241E860", Offset = "0x241D460", VA = "0x18241E860", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x241EA60", Offset = "0x241D660", VA = "0x18241EA60")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x241E8D0", Offset = "0x241D4D0", VA = "0x18241E8D0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
		public SA_SideToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SA_TopToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private Text m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Image m_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x241EC20", Offset = "0x241D820", VA = "0x18241EC20")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x241EAB0", Offset = "0x241D6B0", VA = "0x18241EAB0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x241EAF0", Offset = "0x241D6F0", VA = "0x18241EAF0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x241ED80", Offset = "0x241D980", VA = "0x18241ED80")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x241EB30", Offset = "0x241D730", VA = "0x18241EB30")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
		public SA_TopToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class SA_UIController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Action<int> OnTopMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Action<string> OnSideMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		protected Image m_logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected GameObject m_topMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected GameObject m_sideMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected GameObject m_sideScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected Text m_logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		protected GameObject m_prevSideItem;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SetLogo(Sprite sprite);

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index);

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ShowTopMenuItem(GameObject menuItem);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void UnloadContent();

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LoadContent(GameObject canvas);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AddLog(string log);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
		protected SA_UIController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ISN_ReplayKitUseExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool IsRecording;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x10252C0", Offset = "0x1023EC0", VA = "0x1810252C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x10254E0", Offset = "0x10240E0", VA = "0x1810254E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1025740", Offset = "0x1024340", VA = "0x181025740")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1021310", Offset = "0x101FF10", VA = "0x181021310")]
		public ISN_ReplayKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class ISN_MarketExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static ISN_PaymentManagerExample s_paymentManager;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1023610", Offset = "0x1022210", VA = "0x181023610")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1021310", Offset = "0x101FF10", VA = "0x181021310")]
		public ISN_MarketExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class ISN_PaymentManagerExample : ISN_iSKPaymentTransactionObserver
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public const string SMALL_PACK = "your.product.id1.here";

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public const string NC_PACK = "your.product.id2.here";

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static bool IsInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1025110", Offset = "0x1023D10", VA = "0x181025110")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x1025060", Offset = "0x1023C60", VA = "0x181025060")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x10249B0", Offset = "0x10235B0", VA = "0x1810249B0", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x363590", Offset = "0x362190", VA = "0x180363590", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1024700", Offset = "0x1023300", VA = "0x181024700", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public ISN_PaymentManagerExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class ISN_UIKitExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Texture2D m_icon;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1026FD0", Offset = "0x1025BD0", VA = "0x181026FD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1027150", Offset = "0x1025D50", VA = "0x181027150")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1021310", Offset = "0x101FF10", VA = "0x181021310")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1028880", Offset = "0x1027480", VA = "0x181028880")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x10280F0", Offset = "0x1026CF0", VA = "0x1810280F0")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x10284E0", Offset = "0x10270E0", VA = "0x1810284E0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1028320", Offset = "0x1026F20", VA = "0x181028320")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x1028670", Offset = "0x1027270", VA = "0x181028670")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x10281C0", Offset = "0x1026DC0", VA = "0x1810281C0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x319760", Offset = "0x318360", VA = "0x180319760")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1028A40", Offset = "0x1027640", VA = "0x181028A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x102A200", Offset = "0x1028E00", VA = "0x18102A200")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1029510", Offset = "0x1028110", VA = "0x181029510")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x10296F0", Offset = "0x10282F0", VA = "0x1810296F0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1029190", Offset = "0x1027D90", VA = "0x181029190")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1028D20", Offset = "0x1027920", VA = "0x181028D20")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1021310", Offset = "0x101FF10", VA = "0x181021310")]
		public ISN_UserNotificationsExamples()
		{
		}
	}
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
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
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x102C2B0", Offset = "0x102AEB0", VA = "0x18102C2B0")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x3420D0", Offset = "0x340CD0", VA = "0x1803420D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x102C340", Offset = "0x102AF40", VA = "0x18102C340")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x102C3A0", Offset = "0x102AFA0", VA = "0x18102C3A0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x337C70", Offset = "0x336870", VA = "0x180337C70")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x102C410", Offset = "0x102B010", VA = "0x18102C410")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x337C70", Offset = "0x336870", VA = "0x180337C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x102C410", Offset = "0x102B010", VA = "0x18102C410")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x102C480", Offset = "0x102B080", VA = "0x18102C480")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x102C4F0", Offset = "0x102B0F0", VA = "0x18102C4F0")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x56F940", Offset = "0x56E540", VA = "0x18056F940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x519430", Offset = "0x518030", VA = "0x180519430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x502BD0", Offset = "0x5017D0", VA = "0x180502BD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x102C590", Offset = "0x102B190", VA = "0x18102C590")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x56F940", Offset = "0x56E540", VA = "0x18056F940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x519430", Offset = "0x518030", VA = "0x180519430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x502BD0", Offset = "0x5017D0", VA = "0x180502BD0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x102C590", Offset = "0x102B190", VA = "0x18102C590")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x38BF30", Offset = "0x38AB30", VA = "0x18038BF30")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x102C440", Offset = "0x102B040", VA = "0x18102C440")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x38BF60", Offset = "0x38AB60", VA = "0x18038BF60")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x38BF60", Offset = "0x38AB60", VA = "0x18038BF60")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x38BF60", Offset = "0x38AB60", VA = "0x18038BF60")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace POpusCodec
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class OpusDecoder : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private const int MaxFrameSize = 5760;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private bool _previousPacketInvalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private int _channelCount;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static readonly float[] EmptyBufferFloat;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly short[] EmptyBufferShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Bandwidth? _previousPacketBandwidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private float[] bufferFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private short[] bufferShort;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public SamplingRate SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3A3840", Offset = "0x3A2440", VA = "0x1803A3840")]
			[CompilerGenerated]
			get
			{
				return default(SamplingRate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3A3860", Offset = "0x3A2460", VA = "0x1803A3860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Channels Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x31C6E0", Offset = "0x31B2E0", VA = "0x18031C6E0")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x102ACB0", Offset = "0x10298B0", VA = "0x18102ACB0")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x102A740", Offset = "0x1029340", VA = "0x18102A740")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x102A970", Offset = "0x1029570", VA = "0x18102A970")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x102ABA0", Offset = "0x10297A0", VA = "0x18102ABA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class OpusEncoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public const int BitrateMax = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private const int RecommendedMaxPacketSize = 4000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int _frameSizePerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private SamplingRate _inputSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private Channels _inputChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly byte[] writePacket;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Delay _encoderDelay;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public SamplingRate InputSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x31C6E0", Offset = "0x31B2E0", VA = "0x18031C6E0")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Channels InputChannels
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x31C790", Offset = "0x31B390", VA = "0x18031C790")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Delay EncoderDelay
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3A66F0", Offset = "0x3A52F0", VA = "0x1803A66F0")]
			get
			{
				return default(Delay);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x102B980", Offset = "0x102A580", VA = "0x18102B980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public int FrameSizePerChannel
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x427DA0", Offset = "0x4269A0", VA = "0x180427DA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x102B800", Offset = "0x102A400", VA = "0x18102B800")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x102B920", Offset = "0x102A520", VA = "0x18102B920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Bandwidth MaxBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x102B8A0", Offset = "0x102A4A0", VA = "0x18102B8A0")]
			get
			{
				return default(Bandwidth);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x102BAE0", Offset = "0x102A6E0", VA = "0x18102BAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x102B820", Offset = "0x102A420", VA = "0x18102B820")]
			get
			{
				return default(Complexity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x102B940", Offset = "0x102A540", VA = "0x18102B940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int ExpectedPacketLossPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x102B860", Offset = "0x102A460", VA = "0x18102B860")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x102BAA0", Offset = "0x102A6A0", VA = "0x18102BAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public SignalHint SignalHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x102B8C0", Offset = "0x102A4C0", VA = "0x18102B8C0")]
			get
			{
				return default(SignalHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x102BB00", Offset = "0x102A700", VA = "0x18102BB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ForceChannels ForceChannels
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x102B880", Offset = "0x102A480", VA = "0x18102B880")]
			get
			{
				return default(ForceChannels);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x102BAC0", Offset = "0x102A6C0", VA = "0x18102BAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UseInbandFEC
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x102B8E0", Offset = "0x102A4E0", VA = "0x18102B8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x102BB20", Offset = "0x102A720", VA = "0x18102BB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool UseUnconstrainedVBR
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x102B900", Offset = "0x102A500", VA = "0x18102B900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x102BB40", Offset = "0x102A740", VA = "0x18102BB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DtxEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x102B840", Offset = "0x102A440", VA = "0x18102B840")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x102B960", Offset = "0x102A560", VA = "0x18102B960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x102B3C0", Offset = "0x1029FC0", VA = "0x18102B3C0")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x102AF30", Offset = "0x1029B30", VA = "0x18102AF30")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x102B140", Offset = "0x1029D40", VA = "0x18102B140")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x102AE90", Offset = "0x1029A90", VA = "0x18102AE90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class OpusException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private OpusStatusCode _statusCode;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public OpusStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x102BB60", Offset = "0x102A760", VA = "0x18102BB60")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class Wrapper
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private const string lib_name = "opus_egpv";

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x103B100", Offset = "0x1039D00", VA = "0x18103B100")]
		private static extern int opus_encoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x103B190", Offset = "0x1039D90", VA = "0x18103B190")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x103B250", Offset = "0x1039E50", VA = "0x18103B250")]
		public static extern IntPtr opus_get_version_string();

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x103AAF0", Offset = "0x10396F0", VA = "0x18103AAF0")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x103A890", Offset = "0x1039490", VA = "0x18103A890")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x103AFF0", Offset = "0x1039BF0", VA = "0x18103AFF0")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x103AF40", Offset = "0x1039B40", VA = "0x18103AF40")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x103A640", Offset = "0x1039240", VA = "0x18103A640")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x103A590", Offset = "0x1039190", VA = "0x18103A590")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x103A750", Offset = "0x1039350", VA = "0x18103A750")]
		private static extern int opus_decoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x103A7E0", Offset = "0x10393E0", VA = "0x18103A7E0")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x103A1C0", Offset = "0x1038DC0", VA = "0x18103A1C0")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1039FD0", Offset = "0x1038BD0", VA = "0x181039FD0")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x103B2E0", Offset = "0x1039EE0", VA = "0x18103B2E0")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x103B380", Offset = "0x1039F80", VA = "0x18103B380")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x103B420", Offset = "0x103A020", VA = "0x18103B420")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x103AD50", Offset = "0x1039950", VA = "0x18103AD50")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x103ABE0", Offset = "0x10397E0", VA = "0x18103ABE0")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x103A980", Offset = "0x1039580", VA = "0x18103A980")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x103B0A0", Offset = "0x1039CA0", VA = "0x18103B0A0")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1039EB0", Offset = "0x1038AB0", VA = "0x181039EB0")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x103B5D0", Offset = "0x103A1D0", VA = "0x18103B5D0")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1039D90", Offset = "0x1038990", VA = "0x181039D90")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x103B4B0", Offset = "0x103A0B0", VA = "0x18103B4B0")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x103A3B0", Offset = "0x1038FB0", VA = "0x18103A3B0")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x103A6F0", Offset = "0x10392F0", VA = "0x18103A6F0")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x103A2B0", Offset = "0x1038EB0", VA = "0x18103A2B0")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x103A0C0", Offset = "0x1038CC0", VA = "0x18103A0C0")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1039C60", Offset = "0x1038860", VA = "0x181039C60")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum Bandwidth
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Narrowband = 1101,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		Mediumband,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Wideband,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		SuperWideband,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Fullband
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum Channels
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Stereo
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum Complexity
	{
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Complexity0,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Complexity1,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Complexity2,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Complexity3,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Complexity4,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Complexity5,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Complexity6,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Complexity7,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Complexity8,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Complexity9,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Complexity10
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum Delay
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Delay2dot5ms = 5,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Delay5ms = 10,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Delay10ms = 20,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Delay20ms = 40,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Delay40ms = 80,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Delay60ms = 120
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum ForceChannels
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		NoForce = -1000,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Stereo = 2
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum OpusApplicationType
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Voip = 2048,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		Audio = 2049,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		RestrictedLowDelay = 2051
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	internal enum OpusCtlGetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Application = 4001,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Bitrate = 4003,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		MaxBandwidth = 4005,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		VBR = 4007,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Bandwidth = 4009,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		Complexity = 4011,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		InbandFec = 4013,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		PacketLossPercentage = 4015,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Dtx = 4017,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		VBRConstraint = 4021,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ForceChannels = 4023,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Signal = 4025,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		LookAhead = 4027,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		SampleRate = 4029,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		FinalRange = 4031,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Pitch = 4033,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Gain = 4035,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		LsbDepth = 4037,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		LastPacketDurationRequest = 4039
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	internal enum OpusCtlSetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Application = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Bitrate = 4002,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		MaxBandwidth = 4004,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		VBR = 4006,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Bandwidth = 4008,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Complexity = 4010,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		InbandFec = 4012,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		PacketLossPercentage = 4014,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Dtx = 4016,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		VBRConstraint = 4020,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		ForceChannels = 4022,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Signal = 4024,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Gain = 4034,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		LsbDepth = 4036
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum OpusStatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		OK = 0,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		BadArguments = -1,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		BufferTooSmall = -2,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		InternalError = -3,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		InvalidPacket = -4,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Unimplemented = -5,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		InvalidState = -6,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		AllocFail = -7
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Sampling08000 = 8000,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Sampling12000 = 12000,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Sampling16000 = 16000,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Sampling24000 = 24000,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Sampling48000 = 48000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum SignalHint
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Auto = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Voice = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class AudioUtil
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			protected T[] frameResampled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			private int channels;

			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x101ABE0", Offset = "0x10197E0", VA = "0x18101ABE0")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x101AB90", Offset = "0x1019790", VA = "0x18101AB90", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D4")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		public interface ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000E1")]
			float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004D5")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E2")]
			float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004D6")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E3")]
			float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000E4")]
			float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004D8")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D9")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ResetAccumAvgPeakAmp();
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000E5")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0x578C60", Offset = "0x577860", VA = "0x180578C60", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E6")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x578C60", Offset = "0x577860", VA = "0x180578C60", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E7")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x578C60", Offset = "0x577860", VA = "0x180578C60", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000E8")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0x578C60", Offset = "0x577860", VA = "0x180578C60", Slot = "7")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "8")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
			public LevelMetterDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			protected float ampSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			protected float ampPeak;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			protected int bufferSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			protected float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			protected int prevValuesPtr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			protected float accumAvgPeakAmpSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			protected int accumAvgPeakAmpCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000427")]
			protected float peakAmpForFrame;

			[Cpp2IlInjected.Token(Token = "0x170000E9")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004E1")]
				[Cpp2IlInjected.Address(RVA = "0x10151E0", Offset = "0x1013DE0", VA = "0x1810151E0", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EA")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0x68FB40", Offset = "0x68E740", VA = "0x18068FB40", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x82C420", Offset = "0x82B020", VA = "0x18082C420")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x465D60", Offset = "0x464960", VA = "0x180465D60", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x60004E5")]
				[Cpp2IlInjected.Address(RVA = "0x10151C0", Offset = "0x1013DC0", VA = "0x1810151C0", Slot = "9")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x10150C0", Offset = "0x1013CC0", VA = "0x1810150C0")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x1015030", Offset = "0x1013C30", VA = "0x181015030", Slot = "10")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0x15990A0", Offset = "0x1597CA0", VA = "0x1815990A0")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x1598EF0", Offset = "0x1597AF0", VA = "0x181598EF0", Slot = "11")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0x15992D0", Offset = "0x1597ED0", VA = "0x1815992D0")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x1599100", Offset = "0x1597D00", VA = "0x181599100", Slot = "11")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		public interface IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000ED")]
			bool On
			{
				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(Slot = "1")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(Slot = "3")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x60004F5")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60004F6")]
				[Cpp2IlInjected.Address(Slot = "9")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			event Action OnDetected;
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			private IVoiceDetector voiceDetector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			private ILevelMeter levelMeter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			private int valuesPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			protected int voiceDetectorCalibrateCount;

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			public bool VoiceDetectorCalibrating
			{
				[Cpp2IlInjected.Token(Token = "0x60004F7")]
				[Cpp2IlInjected.Address(RVA = "0x70CEF0", Offset = "0x70BAF0", VA = "0x18070CEF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004F8")]
			[Cpp2IlInjected.Address(RVA = "0x101D000", Offset = "0x101BC00", VA = "0x18101D000")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F9")]
			[Cpp2IlInjected.Address(RVA = "0x101CE80", Offset = "0x101BA80", VA = "0x18101CE80")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x101CD20", Offset = "0x101B920", VA = "0x18101CD20", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x320AB0", Offset = "0x31F6B0", VA = "0x180320AB0", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0x578C60", Offset = "0x577860", VA = "0x180578C60", Slot = "6")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "7")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0x320AB0", Offset = "0x31F6B0", VA = "0x180320AB0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x3662A0", Offset = "0x364EA0", VA = "0x1803662A0", Slot = "12")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "13")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F7")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000504")]
				[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x15AA8C0", Offset = "0x15A94C0", VA = "0x1815AA8C0", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(RVA = "0x15AA960", Offset = "0x15A9560", VA = "0x1815AA960", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private bool detected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			protected int activityDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			protected int autoSilenceCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			protected int valuesCountPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			protected int activityDelayValuesCount;

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0x31A560", Offset = "0x319160", VA = "0x18031A560", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0x31A5A0", Offset = "0x3191A0", VA = "0x18031A5A0", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x519430", Offset = "0x518030", VA = "0x180519430", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x519450", Offset = "0x518050", VA = "0x180519450", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x3420D0", Offset = "0x340CD0", VA = "0x1803420D0", Slot = "10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x101D6A0", Offset = "0x101C2A0", VA = "0x18101D6A0")]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0x3A3840", Offset = "0x3A2440", VA = "0x1803A3840", Slot = "14")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000511")]
				[Cpp2IlInjected.Address(RVA = "0x101D510", Offset = "0x101C110", VA = "0x18101D510", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000512")]
				[Cpp2IlInjected.Address(RVA = "0x101D250", Offset = "0x101BE50", VA = "0x18101D250", Slot = "12")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000513")]
				[Cpp2IlInjected.Address(RVA = "0x101D300", Offset = "0x101BF00", VA = "0x18101D300", Slot = "13")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x101D060", Offset = "0x101BC60", VA = "0x18101D060")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(Slot = "16")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x15AAB30", Offset = "0x15A9730", VA = "0x1815AAB30")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x15AAA00", Offset = "0x15A9600", VA = "0x1815AAA00", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x15AACE0", Offset = "0x15A98E0", VA = "0x1815AACE0")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x15AABA0", Offset = "0x15A97A0", VA = "0x1815AABA0", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EE")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			private VoiceDetectorCalibration<T> c;

			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			public ILevelMeter Level
			{
				[Cpp2IlInjected.Token(Token = "0x600051B")]
				[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600051C")]
				[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			public IVoiceDetector Detector
			{
				[Cpp2IlInjected.Token(Token = "0x600051D")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600051E")]
				[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x101DE20", Offset = "0x101CA20", VA = "0x18101DE20")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x101D750", Offset = "0x101C350", VA = "0x18101D750")]
			public void Calibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x101DC30", Offset = "0x101C830", VA = "0x18101DC30", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x101D780", Offset = "0x101C380", VA = "0x18101D780", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public const float SHORT_TO_NORMALIZED_FLOAT_RATIO = 3.051851E-05f;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xEC22B0", Offset = "0xEC0EB0", VA = "0x180EC22B0")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1595E70", Offset = "0x1594A70", VA = "0x181595E70")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1595BB0", Offset = "0x15947B0", VA = "0x181595BB0")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1595B30", Offset = "0x1594730", VA = "0x181595B30")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1595AA0", Offset = "0x15946A0", VA = "0x181595AA0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xEC21A0", Offset = "0xEC0DA0", VA = "0x180EC21A0")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xEC29E0", Offset = "0xEC15E0", VA = "0x180EC29E0")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface IAudioOut
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		int CurrentBufferLag
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnAudioFrame(float[] frame);

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Service();

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Pause();
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		protected int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		protected TInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private TType[] freeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		protected int pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private bool inited;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x1E17460", Offset = "0x1E16060", VA = "0x181E17460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public TInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3D0", Offset = "0x4FAFD0", VA = "0x1804FC3D0")]
			get
			{
				return (TInfo)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TType createObject(TInfo info);

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void destroyObject(TType obj);

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E172E0", Offset = "0x1E15EE0", VA = "0x181E172E0")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1E17350", Offset = "0x1E15F50", VA = "0x181E17350")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E16BB0", Offset = "0x1E157B0", VA = "0x181E16BB0")]
		public void Init(TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1E165B0", Offset = "0x1E151B0", VA = "0x181E165B0")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1E16760", Offset = "0x1E15360", VA = "0x181E16760")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1E170E0", Offset = "0x1E15CE0", VA = "0x181E170E0", Slot = "8")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1E16F90", Offset = "0x1E15B90", VA = "0x181E16F90", Slot = "9")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E16970", Offset = "0x1E15570", VA = "0x181E16970", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1B3A830", Offset = "0x1B39430", VA = "0x181B3A830")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DC3D00", Offset = "0x1DC2900", VA = "0x181DC3D00")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1E17500", Offset = "0x1E16100", VA = "0x181E17500", Slot = "5")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "6")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83E770", Offset = "0x83D370", VA = "0x18083E770", Slot = "7")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Factory factory;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1014C30", Offset = "0x1013830", VA = "0x181014C30")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1014C80", Offset = "0x1013880", VA = "0x181014C80")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1014CE0", Offset = "0x10138E0", VA = "0x181014CE0", Slot = "5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1014D20", Offset = "0x1013920", VA = "0x181014D20", Slot = "6")]
		protected override void destroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1014D50", Offset = "0x1013950", VA = "0x181014D50", Slot = "7")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class OpusCodec
	{
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		public enum FrameDuration
		{
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			Frame2dot5ms = 2500,
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			Frame5ms = 5000,
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			Frame10ms = 10000,
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			Frame20ms = 20000,
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			Frame40ms = 40000,
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			Frame60ms = 60000
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public static class EncoderFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x1597820", Offset = "0x1596420", VA = "0x181597820")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			protected OpusEncoder encoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			protected bool disposed;

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D5F0", Offset = "0x1E0C1F0", VA = "0x181E0D5F0")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D450", Offset = "0x1E0C050", VA = "0x181E0D450", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public class EncoderFloat : Encoder<float>
		{
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x600052B")]
			[Cpp2IlInjected.Address(RVA = "0x1597C50", Offset = "0x1596850", VA = "0x181597C50")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x1597A80", Offset = "0x1596680", VA = "0x181597A80", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class EncoderShort : Encoder<short>
		{
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x1597E90", Offset = "0x1596A90", VA = "0x181597E90")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x1597CC0", Offset = "0x15968C0", VA = "0x181597CC0", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			private OpusDecoder decoder;

			[Cpp2IlInjected.Token(Token = "0x6000531")]
			[Cpp2IlInjected.Address(RVA = "0x1596CB0", Offset = "0x15958B0", VA = "0x181596CB0", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x1596C00", Offset = "0x1595800", VA = "0x181596C00", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0x1596C50", Offset = "0x1595850", VA = "0x181596C50", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x1596C70", Offset = "0x1595870", VA = "0x181596C70", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x1596C90", Offset = "0x1595890", VA = "0x181596C90", Slot = "8")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
			public Decoder()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		public class Util
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x15AA680", Offset = "0x15A9280", VA = "0x1815AA680")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
			public Util()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public OpusCodec()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public struct AECLatencyResultType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public int LatencyMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public int LatencyDelayedMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public bool PlayDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public bool PlayDelayedDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public bool RecDetected;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool _AEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private int _AECPlaybackDelayMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private bool _AECLatencyDetect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private int frameSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private int samplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private int playDelayFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private int playDelayMaxFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private IntPtr stEcho;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private IntPtr st;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private short[] resultBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Queue<short[]> playBufQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Framer<float> playFramer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private int playSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private int playChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Func<long> clockMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private long detectTimePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private long detectTimePlayDelayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private long detectTimeRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int frameCntRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private int frameCntPlay;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool AEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x31A560", Offset = "0x319160", VA = "0x18031A560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x102E3D0", Offset = "0x102CFD0", VA = "0x18102E3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int AECFilterLengthMs
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3D0", Offset = "0x4FAFD0", VA = "0x1804FC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3E0", Offset = "0x4FAFE0", VA = "0x1804FC3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public int AECPlaybackDelayMs
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x102E3B0", Offset = "0x102CFB0", VA = "0x18102E3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int AECurrentPlayDelayFrames
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x102E2B0", Offset = "0x102CEB0", VA = "0x18102E2B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool AECLatencyDetect
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x31A640", Offset = "0x319240", VA = "0x18031A640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x102E390", Offset = "0x102CF90", VA = "0x18102E390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public AECLatencyResultType AECLatencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x102E180", Offset = "0x102CD80", VA = "0x18102E180")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool Denoise
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x102E360", Offset = "0x102CF60", VA = "0x18102E360")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x102E490", Offset = "0x102D090", VA = "0x18102E490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool AGC
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x102E330", Offset = "0x102CF30", VA = "0x18102E330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x102E460", Offset = "0x102D060", VA = "0x18102E460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float AGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x102E300", Offset = "0x102CF00", VA = "0x18102E300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x102E430", Offset = "0x102D030", VA = "0x18102E430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x102DCD0", Offset = "0x102C8D0", VA = "0x18102DCD0")]
		public void ResetAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x102C620", Offset = "0x102B220", VA = "0x18102C620")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x102E4C0", Offset = "0x102D0C0", VA = "0x18102E4C0")]
		private void set(int param, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x102E4F0", Offset = "0x102D0F0", VA = "0x18102E4F0")]
		private void set(int param, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x102E120", Offset = "0x102CD20", VA = "0x18102E120")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x102E150", Offset = "0x102CD50", VA = "0x18102E150")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x102DE90", Offset = "0x102CA90", VA = "0x18102DE90")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x102D030", Offset = "0x102BC30", VA = "0x18102D030")]
		private void InitLatencyDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x102C840", Offset = "0x102B440", VA = "0x18102C840")]
		public void InitAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x102D230", Offset = "0x102BE30", VA = "0x18102D230")]
		private void InitPlayDelay(int ms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x102D9D0", Offset = "0x102C5D0", VA = "0x18102D9D0", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x102D2F0", Offset = "0x102BEF0", VA = "0x18102D2F0")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730")]
		public void PrintInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x102C6B0", Offset = "0x102B2B0", VA = "0x18102C6B0")]
		private void DestroyEchoState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x102C720", Offset = "0x102B320", VA = "0x18102C720", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class SpeexLib
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private const string lib_name = "libspeexdsp";

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x15A99F0", Offset = "0x15A85F0", VA = "0x1815A99F0")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x15A9960", Offset = "0x15A8560", VA = "0x1815A9960")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x15A98B0", Offset = "0x15A84B0", VA = "0x1815A98B0")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x15A95A0", Offset = "0x15A81A0", VA = "0x1815A95A0")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x15A9770", Offset = "0x15A8370", VA = "0x1815A9770")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x15A9650", Offset = "0x15A8250", VA = "0x1815A9650")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x15A93B0", Offset = "0x15A7FB0", VA = "0x1815A93B0")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x15A9450", Offset = "0x15A8050", VA = "0x1815A9450")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x15A9320", Offset = "0x15A7F20", VA = "0x1815A9320")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x15A8D80", Offset = "0x15A7980", VA = "0x1815A8D80")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x15A8E60", Offset = "0x15A7A60", VA = "0x1815A8E60")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x15A9270", Offset = "0x15A7E70", VA = "0x1815A9270")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x15A9510", Offset = "0x15A8110", VA = "0x1815A9510")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x15A8F30", Offset = "0x15A7B30", VA = "0x1815A8F30")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x15A9130", Offset = "0x15A7D30", VA = "0x1815A9130")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x15A8FE0", Offset = "0x15A7BE0", VA = "0x1815A8FE0")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public SpeexLib()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public interface IDataReader<T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Read(T[] buffer);
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface IServiceable
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Service(LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class LocalVoice : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public const int DATA_POOL_CAPACITY = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private bool debugEchoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		internal VoiceInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected IEncoder encoder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		internal byte id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		internal int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		internal byte evNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		protected object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private int noTransmitCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		internal Dictionary<byte, int> eventTimestamps;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public byte Group
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x31A560", Offset = "0x319160", VA = "0x18031A560")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x31A5A0", Offset = "0x3191A0", VA = "0x18031A5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x15A3250", Offset = "0x15A1E50", VA = "0x1815A3250")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool Transmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x31A660", Offset = "0x319260", VA = "0x18031A660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x31A6D0", Offset = "0x3192D0", VA = "0x18031A6D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool IsTransmitting
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x31A690", Offset = "0x319290", VA = "0x18031A690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x31A710", Offset = "0x319310", VA = "0x18031A710")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3D0", Offset = "0x4FAFD0", VA = "0x1804FC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3E0", Offset = "0x4FAFE0", VA = "0x1804FC3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3581E0", Offset = "0x356DE0", VA = "0x1803581E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool Reliable
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x31A640", Offset = "0x319240", VA = "0x18031A640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x31A6B0", Offset = "0x3192B0", VA = "0x18031A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool Encrypt
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x15A3240", Offset = "0x15A1E40", VA = "0x1815A3240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x15A3B40", Offset = "0x15A2740", VA = "0x1815A3B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IServiceable LocalUserServiceable
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x31A6F0", Offset = "0x3192F0", VA = "0x18031A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool DebugEchoMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x592BE0", Offset = "0x5917E0", VA = "0x180592BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x15A3AD0", Offset = "0x15A26D0", VA = "0x1815A3AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		internal string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x15A32C0", Offset = "0x15A1EC0", VA = "0x1815A32C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x15A3270", Offset = "0x15A1E70", VA = "0x1815A3270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x15A31B0", Offset = "0x15A1DB0", VA = "0x1815A31B0")]
		internal LocalVoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x15A30C0", Offset = "0x15A1CC0", VA = "0x1815A30C0")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x15A34C0", Offset = "0x15A20C0", VA = "0x1815A34C0")]
		protected void resetNoTransmitCnt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x15A3660", Offset = "0x15A2260", VA = "0x1815A3660", Slot = "5")]
		internal virtual void service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x15A34D0", Offset = "0x15A20D0", VA = "0x1815A34D0")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x15A3090", Offset = "0x15A1C90", VA = "0x1815A3090")]
		public void RemoveSelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x15A3020", Offset = "0x15A1C20", VA = "0x1815A3020", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct RemoteVoiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x1110A0", Offset = "0x1104A0", VA = "0x1801110A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x113D50", Offset = "0x113150", VA = "0x180113D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x110250", Offset = "0x10F650", VA = "0x180110250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x12BFD0", Offset = "0x12B3D0", VA = "0x18012BFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x12BF80", Offset = "0x12B380", VA = "0x18012BF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x12BFC0", Offset = "0x12B3C0", VA = "0x18012BFC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x12ED20", Offset = "0x12E120", VA = "0x18012ED20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x12ED30", Offset = "0x12E130", VA = "0x18012ED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x169620", Offset = "0x168A20", VA = "0x180169620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x1D8190", Offset = "0x1D7590", VA = "0x1801D8190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IDecoder Decoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x1483F0", Offset = "0x1477F0", VA = "0x1801483F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x1D8180", Offset = "0x1D7580", VA = "0x1801D8180")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal class RemoteVoice : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal RemoteVoiceOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private byte voiceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal byte lastEvNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Queue<byte[]> frameQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private AutoResetEvent frameQueueReady;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		internal VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xE9DBE0", Offset = "0xE9C7E0", VA = "0x180E9DBE0")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x15A52B0", Offset = "0x15A3EB0", VA = "0x1815A52B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x15A64C0", Offset = "0x15A50C0", VA = "0x1815A64C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x15A6470", Offset = "0x15A5070", VA = "0x1815A6470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x15A53C0", Offset = "0x15A3FC0", VA = "0x1815A53C0")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x15A5640", Offset = "0x15A4240", VA = "0x1815A5640")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x15A67A0", Offset = "0x15A53A0", VA = "0x1815A67A0")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x15A6CC0", Offset = "0x15A58C0", VA = "0x1815A6CC0")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x15A6E70", Offset = "0x15A5A70", VA = "0x1815A6E70")]
		private void receiveNullFrames(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x15A5E30", Offset = "0x15A4A30", VA = "0x1815A5E30")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x15A5C50", Offset = "0x15A4850", VA = "0x1815A5C50")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x15A5650", Offset = "0x15A4250", VA = "0x1815A5650")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x15A5A50", Offset = "0x15A4650", VA = "0x1815A5A50")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x15A5850", Offset = "0x15A4450", VA = "0x1815A5850")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x15A7020", Offset = "0x15A5C20", VA = "0x1815A7020")]
		internal void removeAndDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x15A52E0", Offset = "0x15A3EE0", VA = "0x1815A52E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface IAudioSource : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000056")]
		int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public interface ILocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class LocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static LocalVoiceAudioDummy Dummy;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xD50DB0", Offset = "0xD4F9B0", VA = "0x180D50DB0")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		protected int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		protected int sourceSamplingRateHz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		protected bool resampleSource;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x502BA0", Offset = "0x5017A0", VA = "0x180502BA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x47ECE0", Offset = "0x47D8E0", VA = "0x18047ECE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x10177E0", Offset = "0x10163E0", VA = "0x1810177E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x10167C0", Offset = "0x10153C0", VA = "0x1810167C0", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1017290", Offset = "0x1015E90", VA = "0x181017290")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1017810", Offset = "0x1016410", VA = "0x181017810")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x328AC0", Offset = "0x3276C0", VA = "0x180328AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x502C00", Offset = "0x501800", VA = "0x180502C00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x320AB0", Offset = "0x31F6B0", VA = "0x180320AB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x15A29F0", Offset = "0x15A15F0", VA = "0x1815A29F0")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x15A2AD0", Offset = "0x15A16D0", VA = "0x1815A2AD0")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x15A2C70", Offset = "0x15A1870", VA = "0x1815A2C70")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal enum EventSubcode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		VoiceInfo = 1,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		VoiceRemove,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		Frame
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal enum EventParam : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		VoiceId = 1,
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		SamplingRate = 2,
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		Channels = 3,
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		FrameDurationUs = 4,
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		Bitrate = 5,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		UserData = 10,
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		EventNumber = 11,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		Codec = 12
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogError(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogWarning(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LogInfo(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LogDebug(string fmt, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	internal interface IVoiceFrontend : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AssignChannel(VoiceInfo v);

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IsChannelJoined(int channelId);

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ChannelIdStr(int channelId);

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		string PlayerIdStr(int playerId);

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class VoiceClient : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private RemoteVoiceInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			RemoteVoiceInfo IEnumerator<RemoteVoiceInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000100")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000548")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0xA44EA0", Offset = "0xA43AA0", VA = "0x180A44EA0")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x1033360", Offset = "0x1031F60", VA = "0x181033360", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x1032DE0", Offset = "0x10319E0", VA = "0x181032DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x1033460", Offset = "0x1032060", VA = "0x181033460")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000544")]
			[Cpp2IlInjected.Address(RVA = "0x10334A0", Offset = "0x10320A0", VA = "0x1810334A0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x10334E0", Offset = "0x10320E0", VA = "0x1810334E0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x1033310", Offset = "0x1031F10", VA = "0x181033310", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x1033270", Offset = "0x1031E70", VA = "0x181033270", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x1033270", Offset = "0x1031E70", VA = "0x181033270", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xA44EA0", Offset = "0xA43AA0", VA = "0x180A44EA0")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x10339A0", Offset = "0x10325A0", VA = "0x1810339A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x1033530", Offset = "0x1032130", VA = "0x181033530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1033AA0", Offset = "0x10326A0", VA = "0x181033AA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(RVA = "0x1033AE0", Offset = "0x10326E0", VA = "0x181033AE0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x1033B20", Offset = "0x1032720", VA = "0x181033B20")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x1033950", Offset = "0x1032550", VA = "0x181033950", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x10338B0", Offset = "0x10324B0", VA = "0x1810338B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x10338B0", Offset = "0x10324B0", VA = "0x1810338B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal IVoiceFrontend frontend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private int prevRtt;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int ChannelAuto = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private byte globalGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private byte voiceIdCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private System.Random rnd;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int FramesLost
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x3581E0", Offset = "0x356DE0", VA = "0x1803581E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int FramesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x89C080", Offset = "0x89AC80", VA = "0x18089C080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x89C090", Offset = "0x89AC90", VA = "0x18089C090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x10364F0", Offset = "0x10350F0", VA = "0x1810364F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x1036370", Offset = "0x1034F70", VA = "0x181036370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int RoundTripTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x427DA0", Offset = "0x4269A0", VA = "0x180427DA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x5804F0", Offset = "0x57F0F0", VA = "0x1805804F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int RoundTripTimeVariance
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x31C6E0", Offset = "0x31B2E0", VA = "0x18031C6E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x337C90", Offset = "0x336890", VA = "0x180337C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool SuppressInfoDuplicateWarning
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x38CDA0", Offset = "0x38B9A0", VA = "0x18038CDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x621D80", Offset = "0x620980", VA = "0x180621D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x31A6A0", Offset = "0x3192A0", VA = "0x18031A6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x31A720", Offset = "0x319320", VA = "0x18031A720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int DebugLostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x3A66F0", Offset = "0x3A52F0", VA = "0x1803A66F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x503D30", Offset = "0x502930", VA = "0x180503D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x1036670", Offset = "0x1035270", VA = "0x181036670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x1036710", Offset = "0x1035310", VA = "0x181036710")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x1036780", Offset = "0x1035380", VA = "0x181036780")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		internal byte GlobalGroup
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x4280D0", Offset = "0x426CD0", VA = "0x1804280D0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x1038EE0", Offset = "0x1037AE0", VA = "0x181038EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1034490", Offset = "0x1033090", VA = "0x181034490")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x10348B0", Offset = "0x10334B0", VA = "0x1810348B0")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1034740", Offset = "0x1033340", VA = "0x181034740")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1035E30", Offset = "0x1034A30", VA = "0x181035E30")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x1033E30", Offset = "0x1032A30", VA = "0x181033E30")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xD60500", Offset = "0xD5F100", VA = "0x180D60500")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xD60080", Offset = "0xD5EC80", VA = "0x180D60080")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1036150", Offset = "0x1034D50", VA = "0x181036150")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1034990", Offset = "0x1033590", VA = "0x181034990")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1034560", Offset = "0x1033160", VA = "0x181034560")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1038CF0", Offset = "0x10378F0", VA = "0x181038CF0")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1038C30", Offset = "0x1037830", VA = "0x181038C30")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1037090", Offset = "0x1035C90", VA = "0x181037090")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1034D60", Offset = "0x1033960", VA = "0x181034D60")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1034B30", Offset = "0x1033730", VA = "0x181034B30")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x10359F0", Offset = "0x10345F0", VA = "0x1810359F0")]
		internal void clearRemoteVoices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1035660", Offset = "0x1034260", VA = "0x181035660")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x10374D0", Offset = "0x10360D0", VA = "0x1810374D0")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1037E50", Offset = "0x1036A50", VA = "0x181037E50")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x10367F0", Offset = "0x10353F0", VA = "0x1810367F0")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1038AF0", Offset = "0x10376F0", VA = "0x181038AF0")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x10388E0", Offset = "0x10374E0", VA = "0x1810388E0")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1035420", Offset = "0x1034020", VA = "0x181035420")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x10386A0", Offset = "0x10372A0", VA = "0x1810386A0")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1033F40", Offset = "0x1032B40", VA = "0x181033F40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public interface IEncoder : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface IDecoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Open(VoiceInfo info);
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "0")]
		byte[] DecodeToByte(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float[] DecodeToFloat(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "2")]
		short[] DecodeToShort(byte[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Decode(byte[] buf);
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		ImageFormat OutputImageFormat
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		Flip OutputImageFlip
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		OnImageOutputNative OnOutputImage
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1033DB0", Offset = "0x10329B0", VA = "0x181033DB0")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal class UnsupportedCodecException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1033B70", Offset = "0x1032770", VA = "0x181033B70")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public enum Codec
	{
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		AudioOpus = 11
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public enum ImageFormat
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		I420,
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		YV12,
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		Android420,
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		ABGR,
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		BGRA,
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		ARGB
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum Rotation
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		Rotate0 = 0,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		Rotate90 = 90,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		Rotate180 = 180,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		Rotate270 = 270
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public enum Flip
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class ImageBufferInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x337C70", Offset = "0x336870", VA = "0x180337C70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x337CA0", Offset = "0x3368A0", VA = "0x180337CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3D0", Offset = "0x4FAFD0", VA = "0x1804FC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x4FC3E0", Offset = "0x4FAFE0", VA = "0x1804FC3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int[] Stride
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ImageFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x427DA0", Offset = "0x4269A0", VA = "0x180427DA0")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x5804F0", Offset = "0x57F0F0", VA = "0x1805804F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Rotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x31C6E0", Offset = "0x31B2E0", VA = "0x18031C6E0")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x337C90", Offset = "0x336890", VA = "0x180337C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Flip Flip
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x31C790", Offset = "0x31B390", VA = "0x18031C790")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x53D950", Offset = "0x53C550", VA = "0x18053D950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1598AB0", Offset = "0x15976B0", VA = "0x181598AB0")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public ImageBufferInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public IntPtr[] Planes
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA80", Offset = "0x3EE680", VA = "0x1803EFA80")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "4")]
		public virtual void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1598BF0", Offset = "0x15977F0", VA = "0x181598BF0")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1598BD0", Offset = "0x15977D0", VA = "0x181598BD0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1598B00", Offset = "0x1597700", VA = "0x181598B00", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private GCHandle planeHandle;

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x1598DE0", Offset = "0x15979E0", VA = "0x181598DE0")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x1598D30", Offset = "0x1597930", VA = "0x181598D30")]
		public void PinPlane(byte[] plane)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x1598DA0", Offset = "0x15979A0", VA = "0x181598DA0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	internal static class VoiceCodec
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10390C0", Offset = "0x1037CC0", VA = "0x1810390C0")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1039060", Offset = "0x1037C60", VA = "0x181039060")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum ProcessorQueue
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		RawSignalReading = 0,
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		GainAdjustment = 100,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		GainAdjustedSignalReading = 200,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		Resampling = 300,
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		SignalProcessing = 400,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		ProcessedSignalReading = 500
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class Framer<T>
	{
		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private T[] <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public Framer<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private T[] buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public T[] <>3__buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private int <s>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private int <bufPos>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xD2F900", Offset = "0xD2E500", VA = "0x180D2F900")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x31A730", Offset = "0x319330", VA = "0x18031A730", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0x101AF20", Offset = "0x1019B20", VA = "0x18101AF20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x101B210", Offset = "0x1019E10", VA = "0x18101B210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x101B090", Offset = "0x1019C90", VA = "0x18101B090", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x101B140", Offset = "0x1019D40", VA = "0x18101B140", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private T[] frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int sizeofT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int framePos;

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x1010980", Offset = "0x100F580", VA = "0x181010980")]
		public Framer(int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x10108B0", Offset = "0x100F4B0", VA = "0x1810108B0")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x10108E0", Offset = "0x100F4E0", VA = "0x1810108E0")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x996760", Offset = "0x995360", VA = "0x180996760")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x996D60", Offset = "0x995960", VA = "0x180996D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x15A2F30", Offset = "0x15A1B30", VA = "0x1815A2F30")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		public interface IProcessor : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(Slot = "0")]
			T[] Process(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		private struct ProcessorEntry : IComparable<ProcessorEntry>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public IProcessor processor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int priority;

			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x166FD0", Offset = "0x1663D0", VA = "0x180166FD0", Slot = "4")]
			public int CompareTo(ProcessorEntry other)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Framer<T> framer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private List<ProcessorEntry> processors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private bool dataEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Queue<T[]> pushDataQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AutoResetEvent pushDataQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private int framesSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x42A5B0", Offset = "0x4291B0", VA = "0x18042A5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool PushDataAsyncReady
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x101A4D0", Offset = "0x10190D0", VA = "0x18101A4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x101A5B0", Offset = "0x10191B0", VA = "0x18101A5B0")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1017B50", Offset = "0x1016750", VA = "0x181017B50")]
		public void AddProcessor(ProcessorQueue queue, params IProcessor[] newProcessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1017CB0", Offset = "0x10168B0", VA = "0x181017CB0")]
		public void ClearProcessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1019F90", Offset = "0x1018B90", VA = "0x181019F90")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10191E0", Offset = "0x1017DE0", VA = "0x1810191E0")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10189E0", Offset = "0x10175E0", VA = "0x1810189E0")]
		private void PushDataAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1019A70", Offset = "0x1018670", VA = "0x181019A70")]
		public void PushData(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1018160", Offset = "0x1016D60", VA = "0x181018160", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 40)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public struct VoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Codec Codec
		{
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x121280", Offset = "0x120680", VA = "0x180121280")]
			[CompilerGenerated]
			get
			{
				return default(Codec);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x121290", Offset = "0x120690", VA = "0x180121290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x110140", Offset = "0x10F540", VA = "0x180110140")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x116130", Offset = "0x115530", VA = "0x180116130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public int SourceSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x122530", Offset = "0x121930", VA = "0x180122530")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x167470", Offset = "0x166870", VA = "0x180167470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x1673B0", Offset = "0x1667B0", VA = "0x1801673B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x167440", Offset = "0x166840", VA = "0x180167440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int FrameDurationUs
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x123900", Offset = "0x122D00", VA = "0x180123900")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x167450", Offset = "0x166850", VA = "0x180167450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x131400", Offset = "0x130800", VA = "0x180131400")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x167430", Offset = "0x166830", VA = "0x180167430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public object UserData
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x12ED20", Offset = "0x12E120", VA = "0x18012ED20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x12ED30", Offset = "0x12E130", VA = "0x18012ED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int FrameDurationSamples
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x1673C0", Offset = "0x1667C0", VA = "0x1801673C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1673F0", Offset = "0x1667F0", VA = "0x1801673F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x127D80", Offset = "0x127180", VA = "0x180127D80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x167480", Offset = "0x166880", VA = "0x180167480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x167420", Offset = "0x166820", VA = "0x180167420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x167460", Offset = "0x166860", VA = "0x180167460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x10391B0", Offset = "0x1037DB0", VA = "0x1810391B0")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1673A0", Offset = "0x1667A0", VA = "0x1801673A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x1039210", Offset = "0x1037E10", VA = "0x181039210")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public class RemoteVoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0xE9DBE0", Offset = "0xE9C7E0", VA = "0x180E9DBE0")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x15A52B0", Offset = "0x15A3EB0", VA = "0x1815A52B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int ChannelId
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x3A66F0", Offset = "0x3A52F0", VA = "0x1803A66F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x503D30", Offset = "0x502930", VA = "0x180503D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x503C50", Offset = "0x502850", VA = "0x180503C50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x503D20", Offset = "0x502920", VA = "0x180503D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public byte VoiceId
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x4280D0", Offset = "0x426CD0", VA = "0x1804280D0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8F0CC0", Offset = "0x8EF8C0", VA = "0x1808F0CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x380C80", Offset = "0x37F880", VA = "0x180380C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x38C880", Offset = "0x38B480", VA = "0x18038C880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x15A5240", Offset = "0x15A3E40", VA = "0x1815A5240")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		protected IDataReader<T> reader;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Service(LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xE8E990", Offset = "0xE8D590", VA = "0x180E8E990")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x100DAE0", Offset = "0x100C6E0", VA = "0x18100DAE0")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x100DCE0", Offset = "0x100C8E0", VA = "0x18100DCE0")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x100DB30", Offset = "0x100C730", VA = "0x18100DB30", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x100DA10", Offset = "0x100C610", VA = "0x18100DA10")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x100D800", Offset = "0x100C400", VA = "0x18100D800", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x100D700", Offset = "0x100C300", VA = "0x18100D700")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x100D530", Offset = "0x100C130", VA = "0x18100D530", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private float[] buffer;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x1596670", Offset = "0x1595270", VA = "0x181596670")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x15963F0", Offset = "0x1594FF0", VA = "0x1815963F0", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	internal class VoiceEventCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public const byte Code0 = 201;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x1039170", Offset = "0x1037D70", VA = "0x181039170")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x1039180", Offset = "0x1037D80", VA = "0x181039180")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public VoiceEventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private object sendLock;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public VoiceClient VoiceClient
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x43A4F0", Offset = "0x4390F0", VA = "0x18043A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public new Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x502B50", Offset = "0x501750", VA = "0x180502B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x50F2E0", Offset = "0x50DEE0", VA = "0x18050F2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x502B40", Offset = "0x501740", VA = "0x180502B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x50F2D0", Offset = "0x50DED0", VA = "0x18050F2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public byte GlobalAudioGroup
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x159FE50", Offset = "0x159EA50", VA = "0x18159FE50")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x15A03C0", Offset = "0x159EFC0", VA = "0x1815A03C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x159EF60", Offset = "0x159DB60", VA = "0x18159EF60", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x159EFE0", Offset = "0x159DBE0", VA = "0x18159EFE0", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x159EFA0", Offset = "0x159DBA0", VA = "0x18159EFA0", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x159EF20", Offset = "0x159DB20", VA = "0x18159EF20", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x159EDF0", Offset = "0x159D9F0", VA = "0x18159EDF0", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x159EF10", Offset = "0x159DB10", VA = "0x18159EF10", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x159FAC0", Offset = "0x159E6C0", VA = "0x18159FAC0", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x159FBC0", Offset = "0x159E7C0", VA = "0x18159FBC0")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x159FA80", Offset = "0x159E680", VA = "0x18159FA80")]
		public new void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x159EEB0", Offset = "0x159DAB0", VA = "0x18159EEB0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x159F720", Offset = "0x159E320", VA = "0x18159F720", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x159F020", Offset = "0x159DC20", VA = "0x18159F020")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x159F4F0", Offset = "0x159E0F0", VA = "0x18159F4F0", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x159F180", Offset = "0x159DD80", VA = "0x18159F180", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x3662A0", Offset = "0x364EA0", VA = "0x1803662A0", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x3662A0", Offset = "0x364EA0", VA = "0x1803662A0", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x159FE80", Offset = "0x159EA80", VA = "0x18159FE80")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x15A0250", Offset = "0x159EE50", VA = "0x1815A0250")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x15A0180", Offset = "0x159ED80", VA = "0x1815A0180")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x159EEE0", Offset = "0x159DAE0", VA = "0x18159EEE0", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class AudioInEnumerator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private const string lib_name = "AudioIn";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private IntPtr handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public readonly bool IsSupported;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x15947B0", Offset = "0x15933B0", VA = "0x1815947B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x15941B0", Offset = "0x1592DB0", VA = "0x1815941B0")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1594240", Offset = "0x1592E40", VA = "0x181594240")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x15942E0", Offset = "0x1592EE0", VA = "0x1815942E0")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1594430", Offset = "0x1593030", VA = "0x181594430")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1594380", Offset = "0x1592F80", VA = "0x181594380")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1594640", Offset = "0x1593240", VA = "0x181594640")]
		public AudioInEnumerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x15944E0", Offset = "0x15930E0", VA = "0x1815944E0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x15940C0", Offset = "0x1592CC0", VA = "0x1815940C0")]
		public string NameAtIndex(int idx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1594000", Offset = "0x1592C00", VA = "0x181594000")]
		public int IDAtIndex(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x15940B0", Offset = "0x1592CB0", VA = "0x1815940B0")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1593F20", Offset = "0x1592B20", VA = "0x181593F20", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x1598160", Offset = "0x1596D60", VA = "0x181598160")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x1597F00", Offset = "0x1596B00", VA = "0x181597F00")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x15988B0", Offset = "0x15974B0", VA = "0x1815988B0")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1598910", Offset = "0x1597510", VA = "0x181598910")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1598680", Offset = "0x1597280", VA = "0x181598680")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x1598420", Offset = "0x1597020", VA = "0x181598420")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x339190", Offset = "0x337D90", VA = "0x180339190")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class FriendInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x3420D0", Offset = "0x340CD0", VA = "0x1803420D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x3420F0", Offset = "0x340CF0", VA = "0x1803420F0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool IsInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x3420A0", Offset = "0x340CA0", VA = "0x1803420A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x1598A30", Offset = "0x1597630", VA = "0x181598A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public FriendInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public enum ClientState
	{
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		PeerCreated = 0,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Authenticating = 1,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Authenticated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		JoinedLobby = 3,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		DisconnectingFromMasterserver = 4,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		ConnectingToGameserver = 5,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		ConnectedToGameserver = 6,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		Joining = 7,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		Joined = 8,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Leaving = 9,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		DisconnectingFromGameserver = 10,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		ConnectingToMasterserver = 11,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Disconnecting = 12,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		Disconnected = 13,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		ConnectedToMasterserver = 14,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[Obsolete]
		ConnectedToMaster = 14,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		ConnectingToNameServer = 15,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		ConnectedToNameServer = 16,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		DisconnectingFromNameServer = 17
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	internal enum JoinType
	{
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		CreateRoom,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		JoinRoom,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		JoinRandomRoom,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		JoinOrCreateRoom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public enum DisconnectCause
	{
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		DisconnectByServerUserLimit,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		ExceptionOnConnect,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		DisconnectByServer,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		TimeoutDisconnect,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		Exception,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		InvalidAuthentication,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		MaxCcuReached,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		InvalidRegion,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		OperationNotAllowedInCurrentState,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		CustomAuthenticationFailed,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		DisconnectByServerLogic
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum ServerConnection
	{
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		MasterServer,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		GameServer,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		NameServer
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum EncryptionMode
	{
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		PayloadEncryption = 0,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		DatagramEncryption = 10,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		DatagramEncryptionRandomSequence = 11
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class EncryptionDataParameters
	{
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public const byte Mode = 0;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public const byte Secret1 = 1;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public const byte Secret2 = 2;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public LoadBalancingPeer loadBalancingPeer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AuthModeOption AuthMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public EncryptionMode EncryptionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public ConnectionProtocol ExpectedProtocol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string NameServerHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public string NameServerHttp;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private ClientState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private bool inLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private bool autoJoinLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public bool EnableLobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public Room CurrentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private JoinType lastJoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private bool didAuthenticate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private string[] friendListRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int friendListTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private bool isFetchingFriendList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private byte[] encryptionSecret;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public string AppVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public AuthenticationValues AuthValues
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x31A6F0", Offset = "0x3192F0", VA = "0x18031A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private string TokenForInit
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x159EAD0", Offset = "0x159D6D0", VA = "0x18159EAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public bool IsUsingNameServer
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x31A520", Offset = "0x319120", VA = "0x18031A520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x31A6E0", Offset = "0x3192E0", VA = "0x18031A6E0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public string NameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x159E900", Offset = "0x159D500", VA = "0x18159E900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string CurrentServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x159E7E0", Offset = "0x159D3E0", VA = "0x18159E7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string MasterServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x362800", Offset = "0x361400", VA = "0x180362800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x38FA40", Offset = "0x38E640", VA = "0x18038FA40")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string GameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x31C7A0", Offset = "0x31B3A0", VA = "0x18031C7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x31D000", Offset = "0x31BC00", VA = "0x18031D000")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ServerConnection Server
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3D4E00", Offset = "0x3D3A00", VA = "0x1803D4E00")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x6EA070", Offset = "0x6E8C70", VA = "0x1806EA070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public ClientState State
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x5599A0", Offset = "0x5585A0", VA = "0x1805599A0")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x159ED20", Offset = "0x159D920", VA = "0x18159ED20")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x159E8E0", Offset = "0x159D4E0", VA = "0x18159E8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool IsConnectedAndReady
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x159E870", Offset = "0x159D470", VA = "0x18159E870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public DisconnectCause DisconnectedCause
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x4994A0", Offset = "0x4980A0", VA = "0x1804994A0")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x964500", Offset = "0x963100", VA = "0x180964500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public TypedLobby CurrentLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x332E90", Offset = "0x331A90", VA = "0x180332E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x333960", Offset = "0x332560", VA = "0x180333960")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool AutoJoinLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7C0BB0", Offset = "0x7BF7B0", VA = "0x1807C0BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xBEDB30", Offset = "0xBEC730", VA = "0x180BEDB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x4D9F90", Offset = "0x4D8B90", VA = "0x1804D9F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x50E0F0", Offset = "0x50CCF0", VA = "0x18050E0F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Player LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x328AC0", Offset = "0x3276C0", VA = "0x180328AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x72AD70", Offset = "0x729970", VA = "0x18072AD70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x159EAA0", Offset = "0x159D6A0", VA = "0x18159EAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x159ECE0", Offset = "0x159D8E0", VA = "0x18159ECE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x159EAF0", Offset = "0x159D6F0", VA = "0x18159EAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x159ED70", Offset = "0x159D970", VA = "0x18159ED70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public int PlayersOnMasterCount
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x89E690", Offset = "0x89D290", VA = "0x18089E690")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x32A390", Offset = "0x328F90", VA = "0x18032A390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public int PlayersInRoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x12A7780", Offset = "0x12A6380", VA = "0x1812A7780")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x159ED00", Offset = "0x159D900", VA = "0x18159ED00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public int RoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x103F8D0", Offset = "0x103E4D0", VA = "0x18103F8D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x159ED10", Offset = "0x159D910", VA = "0x18159ED10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public List<FriendInfo> FriendList
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x42A530", Offset = "0x429130", VA = "0x18042A530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x42A870", Offset = "0x429470", VA = "0x18042A870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public int FriendListAge
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x159E800", Offset = "0x159D400", VA = "0x18159E800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x159E840", Offset = "0x159D440", VA = "0x18159E840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public string[] AvailableRegions
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x47ECE0", Offset = "0x47D8E0", VA = "0x18047ECE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x6649A0", Offset = "0x6635A0", VA = "0x1806649A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public string[] AvailableRegionsServers
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4485E0", Offset = "0x4471E0", VA = "0x1804485E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x417CE0", Offset = "0x4168E0", VA = "0x180417CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public string CloudRegion
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x47EBB0", Offset = "0x47D7B0", VA = "0x18047EBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0F0", Offset = "0x5DBCF0", VA = "0x1805DD0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x159E740", Offset = "0x159D340", VA = "0x18159E740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x159EC40", Offset = "0x159D840", VA = "0x18159EC40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x159E600", Offset = "0x159D200", VA = "0x18159E600")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x159EB00", Offset = "0x159D700", VA = "0x18159EB00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x159E6A0", Offset = "0x159D2A0", VA = "0x18159E6A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x159EBA0", Offset = "0x159D7A0", VA = "0x18159EBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x159E400", Offset = "0x159D000", VA = "0x18159E400")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x159E3B0", Offset = "0x159CFB0", VA = "0x18159E3B0")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x159A130", Offset = "0x1598D30", VA = "0x18159A130")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x15999D0", Offset = "0x15985D0", VA = "0x1815999D0")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1599920", Offset = "0x1598520", VA = "0x181599920", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x15996A0", Offset = "0x15982A0", VA = "0x1815996A0")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x15997D0", Offset = "0x15983D0", VA = "0x1815997D0")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1599E20", Offset = "0x1598A20", VA = "0x181599E20")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1599330", Offset = "0x1597F30", VA = "0x181599330")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x159DF90", Offset = "0x159CB90", VA = "0x18159DF90")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x1599D30", Offset = "0x1598930", VA = "0x181599D30")]
		private void DisconnectToReconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1599600", Offset = "0x1598200", VA = "0x181599600")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x159C880", Offset = "0x159B480", VA = "0x18159C880")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x159C570", Offset = "0x159B170", VA = "0x18159C570")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x159C8D0", Offset = "0x159B4D0", VA = "0x18159C8D0")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x124BCA0", Offset = "0x124A8A0", VA = "0x18124BCA0")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x159CA90", Offset = "0x159B690", VA = "0x18159CA90")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x159CB40", Offset = "0x159B740", VA = "0x18159CB40")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x159CBF0", Offset = "0x159B7F0", VA = "0x18159CBF0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x159CD80", Offset = "0x159B980", VA = "0x18159CD80")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x159D0B0", Offset = "0x159BCB0", VA = "0x18159D0B0")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x159C980", Offset = "0x159B580", VA = "0x18159C980")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x159C460", Offset = "0x159B060", VA = "0x18159C460")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x159CE80", Offset = "0x159BA80", VA = "0x18159CE80")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x159CF10", Offset = "0x159BB10", VA = "0x18159CF10")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x159C850", Offset = "0x159B450", VA = "0x18159C850")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x159D1A0", Offset = "0x159BDA0", VA = "0x18159D1A0")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x159D470", Offset = "0x159C070", VA = "0x18159D470")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x159D6B0", Offset = "0x159C2B0", VA = "0x18159D6B0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x159D520", Offset = "0x159C120", VA = "0x18159D520")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x159D5C0", Offset = "0x159C1C0", VA = "0x18159D5C0")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x159D7F0", Offset = "0x159C3F0", VA = "0x18159D7F0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x159D080", Offset = "0x159BC80", VA = "0x18159D080", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x159CFD0", Offset = "0x159BBD0", VA = "0x18159CFD0", Slot = "10")]
		[Obsolete]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x159C440", Offset = "0x159B040", VA = "0x18159C440", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x159DB30", Offset = "0x159C730", VA = "0x18159DB30")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x159DA30", Offset = "0x159C630", VA = "0x18159DA30")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x15993F0", Offset = "0x1597FF0", VA = "0x1815993F0")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1599560", Offset = "0x1598160", VA = "0x181599560")]
		private void CleanCachedValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x1599EA0", Offset = "0x1598AA0", VA = "0x181599EA0")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x159E1C0", Offset = "0x159CDC0", VA = "0x18159E1C0")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x1599A90", Offset = "0x1598690", VA = "0x181599A90", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1599B20", Offset = "0x1598720", VA = "0x181599B20", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x1599C10", Offset = "0x1598810", VA = "0x181599C10", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x159AE80", Offset = "0x1599A80", VA = "0x18159AE80", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x159BD30", Offset = "0x159A930", VA = "0x18159BD30", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x159A300", Offset = "0x1598F00", VA = "0x18159A300", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x159AE20", Offset = "0x1599A20", VA = "0x18159AE20", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x159DFB0", Offset = "0x159CBB0", VA = "0x18159DFB0")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x159D910", Offset = "0x159C510", VA = "0x18159D910")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private enum RoomOptionBit
		{
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			CheckUserOnJoin = 1,
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			DeleteCacheOnLeave = 2,
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			SuppressRoomEvents = 4,
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			PublishUserId = 8,
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			DeleteNullProps = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x400026C")]
		protected internal static Type PingImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly Dictionary<byte, object> opParameters;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x15A2950", Offset = "0x15A1550", VA = "0x1815A2950")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x15A2860", Offset = "0x15A1460", VA = "0x1815A2860")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x15A0500", Offset = "0x159F100", VA = "0x1815A0500")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x15A1210", Offset = "0x159FE10", VA = "0x1815A1210", Slot = "15")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x15A12E0", Offset = "0x159FEE0", VA = "0x1815A12E0", Slot = "16")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x15A19A0", Offset = "0x15A05A0", VA = "0x1815A19A0", Slot = "17")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x15A2480", Offset = "0x15A1080", VA = "0x1815A2480")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x15A0D30", Offset = "0x159F930", VA = "0x1815A0D30", Slot = "18")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x15A16F0", Offset = "0x15A02F0", VA = "0x1815A16F0", Slot = "19")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x15A1430", Offset = "0x15A0030", VA = "0x1815A1430", Slot = "20")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x15A1A50", Offset = "0x15A0650", VA = "0x1815A1A50", Slot = "21")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x15A1040", Offset = "0x159FC40", VA = "0x1815A1040", Slot = "22")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x15A0F70", Offset = "0x159FB70", VA = "0x1815A0F70", Slot = "23")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x15A1E10", Offset = "0x15A0A10", VA = "0x1815A1E10")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x15A1E90", Offset = "0x15A0A90", VA = "0x1815A1E90")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x15A2260", Offset = "0x15A0E60", VA = "0x1815A2260")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x15A1E50", Offset = "0x15A0A50", VA = "0x1815A1E50")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x15A20C0", Offset = "0x15A0CC0", VA = "0x1815A20C0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x15A0970", Offset = "0x159F570", VA = "0x1815A0970", Slot = "24")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x15A06B0", Offset = "0x159F2B0", VA = "0x1815A06B0", Slot = "25")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x15A0C00", Offset = "0x159F800", VA = "0x1815A0C00", Slot = "26")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x15A1B80", Offset = "0x15A0780", VA = "0x1815A1B80", Slot = "27")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x15A2320", Offset = "0x15A0F20", VA = "0x1815A2320", Slot = "28")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public class OpJoinRandomRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Hashtable ExpectedCustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public byte ExpectedMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public MatchmakingMode MatchingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public TypedLobby TypedLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public string SqlLobbyFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class EnterRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public RoomOptions RoomOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public TypedLobby Lobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public Hashtable PlayerProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public bool OnGameServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public bool CreateIfNotExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public bool RejoinOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x38BF20", Offset = "0x38AB20", VA = "0x18038BF20")]
		public EnterRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public class ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public const int Ok = 0;

		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Cpp2IlInjected.Token(Token = "0x400027E")]
		[Obsolete]
		public const int InvalidOperationCode = -2;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const int InvalidOperation = -2;

		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public const int InternalServerError = -1;

		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public const int InvalidAuthentication = 32767;

		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public const int GameIdAlreadyExists = 32766;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public const int GameFull = 32765;

		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public const int GameClosed = 32764;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[Obsolete]
		public const int AlreadyMatched = 32763;

		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public const int ServerFull = 32762;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public const int UserBlocked = 32761;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public const int NoRandomMatchFound = 32760;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const int GameDoesNotExist = 32758;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public const int MaxCcuReached = 32757;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const int InvalidRegion = 32756;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public const int CustomAuthenticationFailed = 32755;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public const int AuthenticationTicketExpired = 32753;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public const int PluginReportedError = 32752;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const int PluginMismatch = 32751;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const int HttpLimitReached = 32745;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const int ExternalHttpCallFailed = 32744;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const int SlotError = 32742;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const int InvalidEncryptionParameters = 32741;

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public ErrorCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class ActorProperties
	{
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const byte PlayerName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const byte IsInactive = 254;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const byte UserId = 253;

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public ActorProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public class GamePropertyKey
	{
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const byte MaxPlayers = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public const byte IsVisible = 254;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public const byte IsOpen = 253;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public const byte PlayerCount = 252;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const byte Removed = 251;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const byte PropsListedInLobby = 250;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const byte CleanupCacheOnLeave = 249;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const byte MasterClientId = 248;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public const byte ExpectedUsers = 247;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public GamePropertyKey()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class EventCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const byte GameList = 230;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public const byte GameListUpdate = 229;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public const byte QueueState = 228;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public const byte Match = 227;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public const byte AppStats = 226;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public const byte LobbyStats = 224;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public const byte PropertiesChanged = 253;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[Obsolete]
		public const byte SetProperties = 253;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public const byte ErrorInfo = 251;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public const byte CacheSliceChanged = 250;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public const byte AuthEvent = 223;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public EventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class ParameterCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public const byte SuppressRoomEvents = 237;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public const byte EmptyRoomTTL = 236;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public const byte PlayerTTL = 235;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public const byte EventForward = 234;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		[Obsolete]
		public const byte IsComingBack = 233;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public const byte IsInactive = 233;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public const byte CheckUserOnJoin = 232;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public const byte ExpectedValues = 231;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public const byte Address = 230;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public const byte PeerCount = 229;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public const byte GameCount = 228;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public const byte MasterPeerCount = 227;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public const byte UserId = 225;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public const byte ApplicationId = 224;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public const byte Position = 223;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public const byte MatchMakingType = 223;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public const byte GameList = 222;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public const byte Secret = 221;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public const byte AppVersion = 220;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[Obsolete]
		public const byte AzureLocalNodeId = 209;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[Obsolete]
		public const byte AzureMasterNodeId = 208;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public const byte RoomName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public const byte Broadcast = 250;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public const byte ActorList = 252;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public const byte ActorNr = 254;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public const byte PlayerProperties = 249;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const byte CustomEventContent = 245;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public const byte Data = 245;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public const byte Code = 244;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const byte GameProperties = 248;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public const byte Properties = 251;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public const byte TargetActorNr = 253;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public const byte ReceiverGroup = 246;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public const byte Cache = 247;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public const byte CleanupCacheOnLeave = 241;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public const byte Group = 240;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public const byte Remove = 239;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public const byte PublishUserId = 239;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const byte Add = 238;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public const byte Info = 218;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const byte ClientAuthenticationType = 217;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public const byte ClientAuthenticationParams = 216;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public const byte JoinMode = 215;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public const byte ClientAuthenticationData = 214;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public const byte MasterClientId = 203;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public const byte FindFriendsRequestList = 1;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const byte LobbyName = 213;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public const byte LobbyType = 212;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const byte LobbyStats = 211;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public const byte Region = 210;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const byte UriPath = 209;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public const byte WebRpcParameters = 208;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public const byte WebRpcReturnCode = 207;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public const byte WebRpcReturnMessage = 206;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public const byte CacheSliceIndex = 205;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const byte Plugins = 204;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const byte NickName = 202;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const byte PluginName = 201;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public const byte PluginVersion = 200;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public const byte ExpectedProtocol = 195;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public const byte CustomInitData = 194;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public const byte EncryptionMode = 193;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public const byte EncryptionData = 192;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public const byte RoomOptionFlags = 191;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public ParameterCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class OperationCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public const byte AuthenticateOnce = 231;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public const byte Authenticate = 230;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public const byte JoinLobby = 229;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public const byte LeaveLobby = 228;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public const byte CreateGame = 227;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public const byte JoinGame = 226;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public const byte JoinRandomGame = 225;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public const byte RaiseEvent = 253;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public const byte SetProperties = 252;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public const byte GetProperties = 251;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public const byte ChangeGroups = 248;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public const byte FindFriends = 222;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public const byte GetLobbyStats = 221;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public const byte GetRegions = 220;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public const byte WebRpc = 219;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public const byte ServerSettings = 218;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public const byte GetGameList = 217;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x3150E0", Offset = "0x313CE0", VA = "0x1803150E0")]
		public OperationCode()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public enum JoinMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		CreateIfNotExists,
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		JoinOrRejoin,
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		RejoinOnly
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public enum MatchmakingMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		FillRoom,
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		SerialMatching,
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		RandomMatching
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public enum ReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		MasterClient
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public enum EventCaching : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[Obsolete]
		MergeCache = 1,
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[Obsolete]
		ReplaceCache = 2,
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[Obsolete]
		RemoveCache = 3,
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		SliceIncreaseIndex = 10,
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		SliceSetIndex = 11,
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		SlicePurgeIndex = 12,
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		SlicePurgeUpToIndex = 13
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		Game = 1,
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		Actor = 2,
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		GameAndActor = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class RoomOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public byte MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int PlayerTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public int EmptyRoomTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private bool cleanupCacheOnLeave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public Hashtable CustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public string[] CustomRoomPropertiesForLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public string[] Plugins;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x31A560", Offset = "0x319160", VA = "0x18031A560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x31A5A0", Offset = "0x3191A0", VA = "0x18031A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x31A660", Offset = "0x319260", VA = "0x18031A660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x31A6D0", Offset = "0x3192D0", VA = "0x18031A6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public bool CleanupCacheOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x31A640", Offset = "0x319240", VA = "0x18031A640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x31A6B0", Offset = "0x3192B0", VA = "0x18031A6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public bool SuppressRoomEvents
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x31A510", Offset = "0x319110", VA = "0x18031A510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x3EDF50", Offset = "0x3ECB50", VA = "0x1803EDF50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool PublishUserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x31A520", Offset = "0x319120", VA = "0x18031A520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x31A6E0", Offset = "0x3192E0", VA = "0x18031A6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool DeleteNullProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x31A650", Offset = "0x319250", VA = "0x18031A650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x31A6C0", Offset = "0x3192C0", VA = "0x18031A6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x15A7C90", Offset = "0x15A6890", VA = "0x1815A7C90")]
		public RoomOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class RaiseEventOptions
	{
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public static readonly RaiseEventOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public EventCaching CachingOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public byte InterestGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int[] TargetActors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public ReceiverGroup Receivers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[Obsolete]
		public byte SequenceChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public WebFlags Flags;

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x15A51D0", Offset = "0x15A3DD0", VA = "0x1815A51D0")]
		public RaiseEventOptions()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public enum LobbyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		SqlLobby = 2,
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		AsyncRandomLobby = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public LobbyType Type;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public static readonly TypedLobby Default;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xC46C70", Offset = "0xC45870", VA = "0x180C46C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x15A9E20", Offset = "0x15A8A20", VA = "0x1815A9E20")]
		public TypedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x446C90", Offset = "0x445890", VA = "0x180446C90")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x15A9D20", Offset = "0x15A8920", VA = "0x1815A9D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int PlayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int RoomCount;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x15A9A90", Offset = "0x15A8690", VA = "0x1815A9A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x15A9C90", Offset = "0x15A8890", VA = "0x1815A9C90")]
		public TypedLobbyInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public enum AuthModeOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		AuthOnce,
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		AuthOnceWss
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public enum CustomAuthenticationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		Facebook = 2,
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		Oculus = 3,
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		Xbox = 5,
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		None = byte.MaxValue
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class AuthenticationValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private CustomAuthenticationType authType;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public CustomAuthenticationType AuthType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x31A560", Offset = "0x319160", VA = "0x18031A560")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x31A5A0", Offset = "0x3191A0", VA = "0x18031A5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public string AuthGetParameters
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x337CB0", Offset = "0x3368B0", VA = "0x180337CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public object AuthPostData
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public string Token
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x31A6F0", Offset = "0x3192F0", VA = "0x18031A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x31A6A0", Offset = "0x3192A0", VA = "0x18031A6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x31A720", Offset = "0x319320", VA = "0x18031A720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xB11B30", Offset = "0xB10730", VA = "0x180B11B30")]
		public AuthenticationValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xB11B00", Offset = "0xB10700", VA = "0x180B11B00")]
		public AuthenticationValues(string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xB11A40", Offset = "0xB10640", VA = "0x180B11A40", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1596140", Offset = "0x1594D40", VA = "0x181596140", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1596370", Offset = "0x1594F70", VA = "0x181596370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public abstract class PhotonPing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public string DebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public bool Successful;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected internal bool GotResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected internal int PingLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected internal byte[] PingBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		protected internal byte PingId;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x15A4010", Offset = "0x15A2C10", VA = "0x1815A4010", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x15A3FC0", Offset = "0x15A2BC0", VA = "0x1815A3FC0", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x15A3F70", Offset = "0x15A2B70", VA = "0x1815A3F70", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B320", Offset = "0xA09F20", VA = "0x180A0B320")]
		protected internal void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x15A4060", Offset = "0x15A2C60", VA = "0x1815A4060")]
		protected PhotonPing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class PingMono : PhotonPing
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private Socket sock;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x15A4270", Offset = "0x15A2E70", VA = "0x1815A4270", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x15A4140", Offset = "0x15A2D40", VA = "0x1815A4140", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x15A40E0", Offset = "0x15A2CE0", VA = "0x1815A40E0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x15A4060", Offset = "0x15A2C60", VA = "0x1815A4060")]
		public PingMono()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class Player
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private int actorID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public readonly bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private string nickName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public object TagObject;

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		protected internal Room RoomReference
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x15A50B0", Offset = "0x15A3CB0", VA = "0x1815A50B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x31A6F0", Offset = "0x3192F0", VA = "0x18031A6F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x15A5090", Offset = "0x15A3C90", VA = "0x1815A5090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool IsInactive
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x592BE0", Offset = "0x5917E0", VA = "0x180592BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x596020", Offset = "0x594C20", VA = "0x180596020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x322020", Offset = "0x320C20", VA = "0x180322020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x322030", Offset = "0x320C30", VA = "0x180322030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public Hashtable AllProperties
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x15A4FF0", Offset = "0x15A3BF0", VA = "0x1815A4FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x15A4FD0", Offset = "0x15A3BD0", VA = "0x1815A4FD0")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x15A4EE0", Offset = "0x15A3AE0", VA = "0x1815A4EE0")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x15A47C0", Offset = "0x15A33C0", VA = "0x1815A47C0")]
		public Player Get(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x15A47B0", Offset = "0x15A33B0", VA = "0x1815A47B0")]
		public Player GetNext()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x15A4790", Offset = "0x15A3390", VA = "0x1815A4790")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x15A4570", Offset = "0x15A3170", VA = "0x1815A4570")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x15A47E0", Offset = "0x15A33E0", VA = "0x1815A47E0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x15A4E60", Offset = "0x15A3A60", VA = "0x1815A4E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x15A4C10", Offset = "0x15A3810", VA = "0x1815A4C10")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x15A44A0", Offset = "0x15A30A0", VA = "0x1815A44A0", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x15A4490", Offset = "0x15A3090", VA = "0x1815A4490")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x15A4A40", Offset = "0x15A3640", VA = "0x1815A4A40")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x15A4B40", Offset = "0x15A3740", VA = "0x1815A4B40")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class Room : RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected internal int PlayerTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected internal int RoomTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private Dictionary<int, Player> players;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x361270", Offset = "0x35FE70", VA = "0x180361270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x3612F0", Offset = "0x35FEF0", VA = "0x1803612F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public new string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x322020", Offset = "0x320C20", VA = "0x180322020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x322030", Offset = "0x320C30", VA = "0x180322030")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public new bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x592BE0", Offset = "0x5917E0", VA = "0x180592BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x15A8A20", Offset = "0x15A7620", VA = "0x1815A8A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public new bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x64BB70", Offset = "0x64A770", VA = "0x18064BB70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x15A8B40", Offset = "0x15A7740", VA = "0x1815A8B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public new byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x31A530", Offset = "0x319130", VA = "0x18031A530")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x15A8C60", Offset = "0x15A7860", VA = "0x1815A8C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public new byte PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x15A89D0", Offset = "0x15A75D0", VA = "0x1815A89D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Dictionary<int, Player> Players
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x3C9E30", Offset = "0x3C8A30", VA = "0x1803C9E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x3C9EA0", Offset = "0x3C8AA0", VA = "0x1803C9EA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public string[] ExpectedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public int MasterClientId
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x380D30", Offset = "0x37F930", VA = "0x180380D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public string[] PropertiesListedInLobby
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x380C80", Offset = "0x37F880", VA = "0x180380C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x38C880", Offset = "0x38B480", VA = "0x18038C880")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public bool AutoCleanUp
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x149DAF0", Offset = "0x149C6F0", VA = "0x18149DAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x15A8910", Offset = "0x15A7510", VA = "0x1815A8910")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x15A7FA0", Offset = "0x15A6BA0", VA = "0x1815A7FA0", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x15A81F0", Offset = "0x15A6DF0", VA = "0x1815A81F0")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x15A7F30", Offset = "0x15A6B30", VA = "0x1815A7F30", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x15A7EF0", Offset = "0x15A6AF0", VA = "0x1815A7EF0", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x15A8070", Offset = "0x15A6C70", VA = "0x1815A8070")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x15A7CE0", Offset = "0x15A68E0", VA = "0x1815A7CE0", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x15A82B0", Offset = "0x15A6EB0", VA = "0x1815A82B0", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x15A7E80", Offset = "0x15A6A80", VA = "0x1815A7E80", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x15A7D70", Offset = "0x15A6970", VA = "0x1815A7D70")]
		public void ClearExpectedUsers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x15A8670", Offset = "0x15A7270", VA = "0x1815A8670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x15A8330", Offset = "0x15A6F30", VA = "0x1815A8330")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected internal bool removedFromList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private Hashtable customProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		protected byte maxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		protected string[] expectedUsers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected bool autoCleanUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected internal int masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected string[] propertiesListedInLobby;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x31A4F0", Offset = "0x3190F0", VA = "0x18031A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x322020", Offset = "0x320C20", VA = "0x180322020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public int PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x31A550", Offset = "0x319150", VA = "0x18031A550")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x31A590", Offset = "0x319190", VA = "0x18031A590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public bool IsLocalClientInside
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x31A500", Offset = "0x319100", VA = "0x18031A500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x31A580", Offset = "0x319180", VA = "0x18031A580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x31A530", Offset = "0x319130", VA = "0x18031A530")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x592BE0", Offset = "0x5917E0", VA = "0x180592BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x64BB70", Offset = "0x64A770", VA = "0x18064BB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x15A7BF0", Offset = "0x15A67F0", VA = "0x1815A7BF0")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x15A7050", Offset = "0x15A5C50", VA = "0x1815A7050", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x15A70F0", Offset = "0x15A5CF0", VA = "0x1815A70F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x15A7980", Offset = "0x15A6580", VA = "0x1815A7980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x15A7670", Offset = "0x15A6270", VA = "0x1815A7670")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x15A7120", Offset = "0x15A5D20", VA = "0x1815A7120", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public class WebRpcResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x3420E0", Offset = "0x340CE0", VA = "0x1803420E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x342100", Offset = "0x340D00", VA = "0x180342100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public int ReturnCode
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x33A7F0", Offset = "0x3393F0", VA = "0x18033A7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x3581E0", Offset = "0x356DE0", VA = "0x1803581E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public string DebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x31A680", Offset = "0x319280", VA = "0x18031A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x31A700", Offset = "0x319300", VA = "0x18031A700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x31A670", Offset = "0x319270", VA = "0x18031A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x31A6F0", Offset = "0x3192F0", VA = "0x18031A6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x15AB0C0", Offset = "0x15A9CC0", VA = "0x1815AB0C0")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x15AAEB0", Offset = "0x15A9AB0", VA = "0x1815AAEB0")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class WebFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public static readonly WebFlags Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public byte WebhookFlags;

		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public const byte HttpForwardConst = 1;

		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public const byte SendAuthCookieConst = 2;

		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public const byte SendSyncConst = 4;

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public const byte SendStateConst = 8;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public bool HttpForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x15AADB0", Offset = "0x15A99B0", VA = "0x1815AADB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x15AADF0", Offset = "0x15A99F0", VA = "0x1815AADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool SendAuthCookie
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x15AADC0", Offset = "0x15A99C0", VA = "0x1815AADC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x15AAE20", Offset = "0x15A9A20", VA = "0x1815AAE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool SendSync
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x15AADE0", Offset = "0x15A99E0", VA = "0x1815AADE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x15AAE80", Offset = "0x15A9A80", VA = "0x1815AAE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool SendState
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x15AADD0", Offset = "0x15A99D0", VA = "0x1815AADD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x15AAE50", Offset = "0x15A9A50", VA = "0x1815AAE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xEDF6E0", Offset = "0xEDE2E0", VA = "0x180EDF6E0")]
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
