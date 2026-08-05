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
	public static class SVUOYMRSQYT
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x97CA180", Offset = "0x97C8B80", VA = "0x1897CA180")]
		public static void XAWDWREGSIR(this AudioSource a, AudioRolloff b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class VXYZJVDFAPX
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97CA8C0", Offset = "0x97C92C0", VA = "0x1897CA8C0")]
		public static float JBWEUOYAVFJ(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97CA920", Offset = "0x97C9320", VA = "0x1897CA920")]
		public static float WVMGEYYULBR(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97CA860", Offset = "0x97C9260", VA = "0x1897CA860")]
		public static float BEVNREYEKZA(float[] a)
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
		private const float JUQPARKBACR = 1f;

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
		[Cpp2IlInjected.Address(RVA = "0x97C7670", Offset = "0x97C6070", VA = "0x1897C7670")]
		public float QRVOMGWZZBL(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x97C7940", Offset = "0x97C6340", VA = "0x1897C7940")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int UIMGIGIRSHK = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ESRIEFUDIWN<float> DUUJQKGVLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int RXFDSGMHYEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float SVOKSBEXQFH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int HPBLQAJLARG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A0C0", VA = "0x180D1B6C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x97C7D70", Offset = "0x97C6770", VA = "0x1897C7D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float SBLDRHFDIZC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x97C7CE0", Offset = "0x97C66E0", VA = "0x1897C7CE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float AVFMHDFQMPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x97C7CB0", Offset = "0x97C66B0", VA = "0x1897C7CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDE3D20", Offset = "0xDE2720", VA = "0x180DE3D20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool IJYLSMYPCVY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x97C7960", Offset = "0x97C6360", VA = "0x1897C7960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x97C7BD0", Offset = "0x97C65D0", VA = "0x1897C7BD0")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x97C79E0", Offset = "0x97C63E0", VA = "0x1897C79E0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x97C7C20", Offset = "0x97C6620", VA = "0x1897C7C20")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LFLDDTPEAEZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		int YQQEVCUDHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Dictionary<string, EnumChoiceData> KWYIQCDQEAS();

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Dictionary<string, EnumChoiceData> NHZAFZUFPXA();

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IList<(string, ChannelAndSubChannel)> UNYYKVKTZXS();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ChannelAndSubChannel DDAFVPHBEIW();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "4")]
		AudioMixerGroup ODBPVZTROSZ(Channel a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "5")]
		AudioMixerGroup DSAFABBGLWH(ChannelAndSubChannel a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "6")]
		SFXAudioSource MMFCNLCVDUL(RecRoomAudioClip a, Transform b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void UWAHSTHLHFC(SFXAudioSource a);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "8")]
		SFXAudioSource LDGZYCPCIAZ(RecRoomAudioClip[] a, bool b = false, float c = 1f, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "9")]
		SFXAudioSource TERUJRCRWVQ(RecRoomAudioClip[] a, Transform b, [Optional] AudioRolloff c, bool d = false, [Optional] Action<SFXAudioSource> e, [Optional] ChannelAndSubChannel? f);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		SFXAudioSource KYAYVINXIWL(RecRoomAudioClip a, Vector3 b, [Optional] AudioRolloff c, [Optional] Action<SFXAudioSource> d, [Optional] ChannelAndSubChannel? e, bool f = false, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		SFXAudioSource DEDCWQQQKMQ(RecRoomAudioClip a, [Optional] Action<SFXAudioSource> b, [Optional] ChannelAndSubChannel? c, bool d = false);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97C7E60", Offset = "0x97C6860", VA = "0x1897C7E60", Slot = "12")]
		ObjectPool.PooledObject<SFXAudioSource> KEGDULKXKKW(bool a)
		{
			return default(ObjectPool.PooledObject<SFXAudioSource>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ObjectPool.PooledObject<SFXAudioSource> EKNIHESIBUU();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ObjectPool.PooledObject<SFXAudioSource> LVUMBIUQTAT();

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "15")]
		VOFDHKTSCRY YPMGVZOUWBI(SFXAudioSource a, float b, float c);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static System.Random MQZNXHHRAXY;

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
			[Cpp2IlInjected.Address(RVA = "0x97C8460", Offset = "0x97C6E60", VA = "0x1897C8460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x97C84B0", Offset = "0x97C6EB0", VA = "0x1897C84B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97C8240", Offset = "0x97C6C40", VA = "0x1897C8240")]
		public static RecRoomAudioClip HHDLEVRGKBB(RecRoomAudioClip a, RecRoomAudioClip[] b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x97C8410", Offset = "0x97C6E10", VA = "0x1897C8410")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x97C8420", Offset = "0x97C6E20", VA = "0x1897C8420")]
		public RecRoomAudioClip(AudioClip clip)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x97C8340", Offset = "0x97C6D40", VA = "0x1897C8340")]
		public bool WIFHRVOGXBX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x97C81D0", Offset = "0x97C6BD0", VA = "0x1897C81D0")]
		public RecRoomAudioClip DLOTDAPOFQY()
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97C8110", Offset = "0x97C6B10", VA = "0x1897C8110")]
		public bool HasValidClip()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xDA5E70", Offset = "0xDA4870", VA = "0x180DA5E70")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x242B9E0", Offset = "0x242A3E0", VA = "0x18242B9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			get
			{
				return default(SFXTrack.AudioType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97C73F0", Offset = "0x97C5DF0", VA = "0x1897C73F0")]
		protected void MSVIIVOLKVI(string a, SFXTrack.AudioType b, Guid c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97C7570", Offset = "0x97C5F70", VA = "0x1897C7570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97C7490", Offset = "0x97C5E90", VA = "0x1897C7490", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97C75C0", Offset = "0x97C5FC0", VA = "0x1897C75C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xDA2840", Offset = "0xDA1240", VA = "0x180DA2840", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97C8540", Offset = "0x97C6F40", VA = "0x1897C8540")]
		public void EditorSetValues(string friendlyName, SFXTrack.AudioType trackType, Guid guid, float clipLengthSeconds, AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x97C75C0", Offset = "0x97C5FC0", VA = "0x1897C75C0")]
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
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int AEFNCPMWIYQ;

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x97C7E00", Offset = "0x97C6800", VA = "0x1897C7E00")]
			internal WEWSIDRDOGP<Guid>.Pair PCVGGEVGTXF(RuntimeAddressableSFXTrack a)
			{
				return default(WEWSIDRDOGP<Guid>.Pair);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private WEWSIDRDOGP<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x97CA150", Offset = "0x97C8B50", VA = "0x1897CA150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public WEWSIDRDOGP<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x97C9FD0", Offset = "0x97C89D0", VA = "0x1897C9FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x97C9C00", Offset = "0x97C8600", VA = "0x1897C9C00")]
		public OIRALRYLARL<AudioClip> LoadClip(Guid clipId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97C9EB0", Offset = "0x97C88B0", VA = "0x1897C9EB0")]
		private OIRALRYLARL<AudioClip> YQMKKSICRKT(AssetReference a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97C9F40", Offset = "0x97C8940", VA = "0x1897C9F40")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, GYZYZYAOQYQ.NJJFBFCELHL
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
			public float APSAQANEFAR
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x97C8040", Offset = "0x97C6A40", VA = "0x1897C8040")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Channel CAJDGKXRYBQ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0x97C80C0", Offset = "0x97C6AC0", VA = "0x1897C80C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x97CA240", Offset = "0x97C8C40", VA = "0x1897CA240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x97CA800", Offset = "0x97C9200", VA = "0x1897CA800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class PELHACHGJBI : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public PELHACHGJBI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x97C7F80", Offset = "0x97C6980", VA = "0x1897C7F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x97C8000", Offset = "0x97C6A00", VA = "0x1897C8000", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> GPYUGSOFBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private AMDZPRIEGWL QZRRYEQFOSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool IALLBIWYLPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OTIPMTGRWOI OBBHHEADXYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LFLDDTPEAEZ GWXBKLMUYTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool? MGUJNSDSPYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float JMJLUCFKGXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float PHSNCBLOHME;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string QONSNNUORBN = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform VFGENZBTJZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource SIUEZKGVBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool KVCATCDBHXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x97C86F0", Offset = "0x97C70F0", VA = "0x1897C86F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int NQWJUEMDCWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x97C9AE0", Offset = "0x97C84E0", VA = "0x1897C9AE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool JTDHBDNYWJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x97C9BC0", Offset = "0x97C85C0", VA = "0x1897C9BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool PGYLVALZPFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x97C9BA0", Offset = "0x97C85A0", VA = "0x1897C9BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float NEOIMSGVNVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x97C9BE0", Offset = "0x97C85E0", VA = "0x1897C9BE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NWBHPSQUDCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x97C9B00", Offset = "0x97C8500", VA = "0x1897C9B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x97C8600", Offset = "0x97C7000", VA = "0x1897C8600")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x97C8E00", Offset = "0x97C7800", VA = "0x1897C8E00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97C9A00", Offset = "0x97C8400", VA = "0x1897C9A00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97C99E0", Offset = "0x97C83E0", VA = "0x1897C99E0")]
		public void UpdateVolume(float volume)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97C97D0", Offset = "0x97C81D0", VA = "0x1897C97D0")]
		public void UpdatePitch(float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97C9730", Offset = "0x97C8130", VA = "0x1897C9730")]
		public void UpdateDopplerLevel(float dopplerLevel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x97C9940", Offset = "0x97C8340", VA = "0x1897C9940")]
		public void UpdateSpatialBlend(float spatialBlend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97C9630", Offset = "0x97C8030", VA = "0x1897C9630")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97C90E0", Offset = "0x97C7AE0", VA = "0x1897C90E0")]
		public void Play(AudioClip clip, float volume, Vector3 point, float pitchVariation, float pitchShift, AudioRolloff rolloff, [Optional] Action<SFXAudioSource> onAudioSourceReleaseCallback, [Optional] ChannelAndSubChannel? channel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97C8F90", Offset = "0x97C7990", VA = "0x1897C8F90")]
		[AsyncStateMachine(typeof(<PlayAsync>d__38))]
		public Task PlayAsync(AudioClip clip, PlayParams playParams, CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97C8970", Offset = "0x97C7370", VA = "0x1897C8970")]
		private void NDTENHKVNCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97C8920", Offset = "0x97C7320", VA = "0x1897C8920")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97C96C0", Offset = "0x97C80C0", VA = "0x1897C96C0")]
		public void StopLooping()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97C9660", Offset = "0x97C8060", VA = "0x1897C9660")]
		public void Scrub(float time)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97C96F0", Offset = "0x97C80F0", VA = "0x1897C96F0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x97C9550", Offset = "0x97C7F50", VA = "0x1897C9550")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x97C94E0", Offset = "0x97C7EE0", VA = "0x1897C94E0")]
		[IteratorStateMachine(typeof(PELHACHGJBI))]
		public IEnumerator<IUPNMORLIQV> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x97C8910", Offset = "0x97C7310", VA = "0x1897C8910", Slot = "4")]
		private void IHBYJVQUBJZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
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
