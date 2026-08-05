using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Build;
using RecRoom.Configs;
using RecRoom.Core;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Pools;
using RecRoom.DataLayer.Audio;
using RecRoom.DataStructures;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.NoEngine.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class UMMCCDWZQHS
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x833A840", Offset = "0x8339640", VA = "0x18833A840")]
		public static void YRFPFEOUUEK(this AudioSource a, AudioRolloff b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class DYTJVHIJJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8337DF0", Offset = "0x8336BF0", VA = "0x188337DF0")]
		public static float PKSFDBEPXJG(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8337DB0", Offset = "0x8336BB0", VA = "0x188337DB0")]
		public static float DNPYXHLAFJK(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8337E50", Offset = "0x8336C50", VA = "0x188337E50")]
		public static float PLQXMQQFIFF(float[] a)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowSerialization]
	public enum AudioPriority : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		MaxPriority = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Music_2D = 5,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SFX_2D = 15,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		Voice_AI = 50,
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		Voice_2D = 100,
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Ambient_2D = 115,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Default = 128,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		LowestPriority = 255
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float JBYGLFJFOWM = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8337620", Offset = "0x8336420", VA = "0x188337620")]
		public float VWRGABOYAPO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83378F0", Offset = "0x83366F0", VA = "0x1883378F0")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int WECCHWKXCDP = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DOSUPBDNAGE<float> BGFVBFKJYNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int CJVVMVHRKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float DDSKXEREFZE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TTGDMXCNBMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xACE310", Offset = "0xACD110", VA = "0x180ACE310")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8337D20", Offset = "0x8336B20", VA = "0x188337D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float KUACQNUFVJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8337C90", Offset = "0x8336A90", VA = "0x188337C90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float WPHZQHSXKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8337C60", Offset = "0x8336A60", VA = "0x188337C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xBAE2F0", Offset = "0xBAD0F0", VA = "0x180BAE2F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool FWKZLSCWGHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8337B50", Offset = "0x8336950", VA = "0x188337B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8337B00", Offset = "0x8336900", VA = "0x188337B00")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8337910", Offset = "0x8336710", VA = "0x188337910")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8337BD0", Offset = "0x83369D0", VA = "0x188337BD0")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface SNBBPCRCOSK
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int SLRSYJQCENT
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Dictionary<string, EnumChoiceData> BRCMYISVLMZ();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Dictionary<string, EnumChoiceData> ZUYGPMEGSUH();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IList<(string, ChannelAndSubChannel)> LKOYOXPFHSH();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ChannelAndSubChannel BKETOMEKLKT();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AudioMixerGroup ZAEIQRKAFBQ(Channel a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AudioMixerGroup CCZQZLBJEES(ChannelAndSubChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		SFXAudioSource VWWREIIPERW(RecRoomAudioClip a, Transform b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WHKGCYBRZVH(SFXAudioSource a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SFXAudioSource NOTQUPTVUTY(RecRoomAudioClip[] a, bool b = false, float c = 1f, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SFXAudioSource AATYSUAZSFD(RecRoomAudioClip[] a, Transform b, [Optional] AudioRolloff c, bool d = false, [Optional] Action<SFXAudioSource> e, [Optional] ChannelAndSubChannel? f);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SFXAudioSource LPGLIOBQDVG(RecRoomAudioClip a, Vector3 b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e, bool f = false, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SFXAudioSource WJEVYQXFPPJ(RecRoomAudioClip a, [Optional] Action<SFXAudioSource> b, [Optional] ChannelAndSubChannel? c, bool d = false);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x833A110", Offset = "0x8338F10", VA = "0x18833A110", Slot = "12")]
		ObjectPool.PooledObject<SFXAudioSource> WNUAQJHFHNF(bool a)
		{
			return default(ObjectPool.PooledObject<SFXAudioSource>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ObjectPool.PooledObject<SFXAudioSource> JQZPRORIHGV();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectPool.PooledObject<SFXAudioSource> MECDBMLEWFM();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		JHHJDZQKJVL NACVTFWOMEZ(SFXAudioSource a, float b, float c);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static System.Random KCVGGNGKVPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Header("Volume")]
		[SerializeField]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Header("Pitch")]
		[Range(0f, 2f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8338400", Offset = "0x8337200", VA = "0x188338400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8338450", Offset = "0x8337250", VA = "0x188338450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8338230", Offset = "0x8337030", VA = "0x188338230")]
		public static RecRoomAudioClip XJSVZOZTTBW(RecRoomAudioClip a, RecRoomAudioClip[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83383B0", Offset = "0x83371B0", VA = "0x1883383B0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83383C0", Offset = "0x83371C0", VA = "0x1883383C0")]
		public RecRoomAudioClip(AudioClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83381E0", Offset = "0x8336FE0", VA = "0x1883381E0")]
		public bool TINBJAPTYVK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8338160", Offset = "0x8336F60", VA = "0x188338160")]
		public RecRoomAudioClip OGSSKUHWMTD()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83380A0", Offset = "0x8336EA0", VA = "0x1883380A0")]
		public bool HasValidClip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xB611A0", Offset = "0xB5FFA0", VA = "0x180B611A0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		protected SFXTrack.AudioType trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x219B3D0", Offset = "0x219A1D0", VA = "0x18219B3D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SFXTrack.AudioType TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0")]
			get
			{
				return default(SFXTrack.AudioType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83374D0", Offset = "0x83362D0", VA = "0x1883374D0")]
		protected void WPZCKPJBHLL(string a, SFXTrack.AudioType b, Guid c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8337480", Offset = "0x8336280", VA = "0x188337480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83373A0", Offset = "0x83361A0", VA = "0x1883373A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8337570", Offset = "0x8336370", VA = "0x188337570")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB5F510", Offset = "0xB5E310", VA = "0x180B5F510", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83384E0", Offset = "0x83372E0", VA = "0x1883384E0")]
		public void EditorSetValues(string friendlyName, SFXTrack.AudioType trackType, Guid guid, float clipLengthSeconds, AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8337570", Offset = "0x8336370", VA = "0x188337570")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NLBGUTCZJKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int NYQIKMSSDXB;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NLBGUTCZJKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8337EB0", Offset = "0x8336CB0", VA = "0x188337EB0")]
			internal QTUOFQYXXNA<Guid>.Pair JDQIDKBSUHC(RuntimeAddressableSFXTrack a)
			{
				return default(QTUOFQYXXNA<Guid>.Pair);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private QTUOFQYXXNA<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x833A0E0", Offset = "0x8338EE0", VA = "0x18833A0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public QTUOFQYXXNA<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8339F60", Offset = "0x8338D60", VA = "0x188339F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8339B90", Offset = "0x8338990", VA = "0x188339B90")]
		public XNDFGATNVRQ<AudioClip> LoadClip(Guid clipId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8339E40", Offset = "0x8338C40", VA = "0x188339E40")]
		private XNDFGATNVRQ<AudioClip> REBPCAOAHAG(AssetReference a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8339ED0", Offset = "0x8338CD0", VA = "0x188339ED0")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, FVLMKPUKXQX.AHSSNHWCPKS
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct PlayParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? Volume;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float? VolumeScalar;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Vector3 Point;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Transform FollowTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AudioRolloff AudioRolloff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float PitchShift;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float PitchVariation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Channel? Channel;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public float EGZIKKOKCFI
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x8337F60", Offset = "0x8336D60", VA = "0x188337F60")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Channel PYRARQQULQP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x8337F10", Offset = "0x8336D10", VA = "0x188337F10")]
				get
				{
					return default(Channel);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <PlayAsync>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public PlayParams playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x833A220", Offset = "0x8339020", VA = "0x18833A220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x833A7E0", Offset = "0x83395E0", VA = "0x18833A7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class RMPZGJCTFSX : IEnumerator<NCPAWUBDFGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private NCPAWUBDFGC LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private NCPAWUBDFGC HYUNTVFBJEN
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public RMPZGJCTFSX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8337FE0", Offset = "0x8336DE0", VA = "0x188337FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8338060", Offset = "0x8336E60", VA = "0x188338060", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> YOESIZYJJXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private JWWHWLOHQXU LTKGMJYAQSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool HSFZEAEQKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private MNPPKFJRFBH BESSRFBSAEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private SNBBPCRCOSK CFXLWCJHPVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool? PMYZUAPHURV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float SFOGUPWOXEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float QCAPSEXSICD;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string OGQBPSLOIYY = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform WHDONOPUIJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x180ACC890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource BUTYWEWBXPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool KRVZBHFOIXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8338690", Offset = "0x8337490", VA = "0x188338690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int JEBLIYWPUUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8339A70", Offset = "0x8338870", VA = "0x188339A70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HNRENYVSDOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8339B50", Offset = "0x8338950", VA = "0x188339B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool DLUGINOTCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8339B30", Offset = "0x8338930", VA = "0x188339B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IUVVAZIHEQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8339B70", Offset = "0x8338970", VA = "0x188339B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PHUWZUKIQUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8339A90", Offset = "0x8338890", VA = "0x188339A90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83385A0", Offset = "0x83373A0", VA = "0x1883385A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8338910", Offset = "0x8337710", VA = "0x188338910")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8339990", Offset = "0x8338790", VA = "0x188339990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8339970", Offset = "0x8338770", VA = "0x188339970")]
		public void UpdateVolume(float volume)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8339760", Offset = "0x8338560", VA = "0x188339760")]
		public void UpdatePitch(float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83396C0", Offset = "0x83384C0", VA = "0x1883396C0")]
		public void UpdateDopplerLevel(float dopplerLevel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83398D0", Offset = "0x83386D0", VA = "0x1883398D0")]
		public void UpdateSpatialBlend(float spatialBlend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83395C0", Offset = "0x83383C0", VA = "0x1883395C0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8339080", Offset = "0x8337E80", VA = "0x188339080")]
		public void Play(AudioClip clip, float volume, Vector3 point, float pitchVariation, float pitchShift, AudioRolloff rolloff, [Optional] Action<SFXAudioSource> onAudioSourceReleaseCallback, [Optional] ChannelAndSubChannel? channel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8338F30", Offset = "0x8337D30", VA = "0x188338F30")]
		[AsyncStateMachine(typeof(<PlayAsync>d__38))]
		public Task PlayAsync(AudioClip clip, PlayParams playParams, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8338AA0", Offset = "0x83378A0", VA = "0x188338AA0")]
		private void PBFGSNYLDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83388C0", Offset = "0x83376C0", VA = "0x1883388C0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8339650", Offset = "0x8338450", VA = "0x188339650")]
		public void StopLooping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83395F0", Offset = "0x83383F0", VA = "0x1883395F0")]
		public void Scrub(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8339680", Offset = "0x8338480", VA = "0x188339680")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83394E0", Offset = "0x83382E0", VA = "0x1883394E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8339470", Offset = "0x8338270", VA = "0x188339470")]
		[IteratorStateMachine(typeof(RMPZGJCTFSX))]
		public IEnumerator<NCPAWUBDFGC> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83388B0", Offset = "0x83376B0", VA = "0x1883388B0", Slot = "4")]
		private void KCMJXBMDSFQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public SFXAudioSource()
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
