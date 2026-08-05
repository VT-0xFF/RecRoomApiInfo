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
using RecRoom.Audio;
using RecRoom.Configs;
using RecRoom.Core.Pools;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MIJOFJAKBLM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83026F0", Offset = "0x83010F0", VA = "0x1883026F0")]
	public static void POKFLHPIOAP(this AudioSource KFNIJLHHNAG, AudioRolloff EPCIIDCOEMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNBGMEIAOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8302690", Offset = "0x8301090", VA = "0x188302690")]
	public static float IIJLAANFKGM(float PLPANMAOIEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8302650", Offset = "0x8301050", VA = "0x188302650")]
	public static float DOAFHPJOBMG(float MJPFNLDLKBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83025F0", Offset = "0x8300FF0", VA = "0x1883025F0")]
	public static float AHAEKAGNOFH(float[] BLPDDGCLNPE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[MEHDELHJEOO]
public enum LDJGBFABNFB : byte
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
	LowestPriority = byte.MaxValue
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float ROLL_OFF_SCALE = 1f;

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
		[Cpp2IlInjected.Address(RVA = "0x8301B50", Offset = "0x8300550", VA = "0x188301B50")]
		public float LNMNBMGEJJA(float FJBMIFMHGAP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8301E20", Offset = "0x8300820", VA = "0x188301E20")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int CHNJLGLNEGH = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BDGFODODOFJ<float> PGKDIPAPOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int NIPBNNGNJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float GFJNOCPIKJO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int EHNBJLKMNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8302250", Offset = "0x8300C50", VA = "0x188302250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ICCDLOMCKGL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x83021C0", Offset = "0x8300BC0", VA = "0x1883021C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float AADPIBEJHBP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8302190", Offset = "0x8300B90", VA = "0x188302190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDDC040", Offset = "0xDDAA40", VA = "0x180DDC040")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool NOLBDOFBGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8302030", Offset = "0x8300A30", VA = "0x188302030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83020B0", Offset = "0x8300AB0", VA = "0x1883020B0")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8301E40", Offset = "0x8300840", VA = "0x188301E40")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8302100", Offset = "0x8300B00", VA = "0x188302100")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FLLMPDGKPPM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int DKNHHFKMBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, MAHLLPPHLEI> KLMLHAAELJG();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, MAHLLPPHLEI> JHABKNNFHKG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, EOLJMEJCHDF)> KGMOMCFMJNE();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOLJMEJCHDF HAIPPMEKLIG();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup CBKANAEEHFB(GLPGDNLNMKB FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup NFLJFCNMOLD(EOLJMEJCHDF LJGBMEAPGDG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource AIGNKIDMHMA(RecRoomAudioClip OKOLOIJKLEN, Transform KNJGJFPCEJG, [Optional] AudioRolloff ABIIKEPOALI, [Optional] Action<SFXAudioSource> CGPDOKJIHHP, [Optional] EOLJMEJCHDF? FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCBGDMMGLCJ(SFXAudioSource FNBEJKIAEFA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource DEBGAMKHJKB(RecRoomAudioClip[] IFJOINJIKGA, bool CCMDALAFJNC = false, float EBELEFBMGBG = 1f, [Optional] Action<SFXAudioSource> CGPDOKJIHHP, [Optional] EOLJMEJCHDF? FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource ILMBGELPBEC(RecRoomAudioClip[] IFJOINJIKGA, Transform KNJGJFPCEJG, [Optional] AudioRolloff ABIIKEPOALI, bool CCMDALAFJNC = false, [Optional] Action<SFXAudioSource> CGPDOKJIHHP, [Optional] EOLJMEJCHDF? FLIDFJKDJOB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource FIDIELMNKEL(RecRoomAudioClip KDJLDINNMIP, Vector3 DPIEBKDJHFN, [Optional] AudioRolloff ABIIKEPOALI, [Optional] Action<SFXAudioSource> CGPDOKJIHHP, [Optional] EOLJMEJCHDF? FLIDFJKDJOB, bool HPAGPEBDHDF = false, bool JNBBGHHHPGN = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource GJKBAIPDHBM(RecRoomAudioClip PLAOIBBOMPH, [Optional] Action<SFXAudioSource> CGPDOKJIHHP, [Optional] EOLJMEJCHDF? FLIDFJKDJOB, bool HPAGPEBDHDF = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8302340", Offset = "0x8300D40", VA = "0x188302340", Slot = "12")]
	ObjectPool.LLPPOAPAJOG<SFXAudioSource> LFMKOOAECPE(bool MABPCPBCIHO)
	{
		return default(ObjectPool.LLPPOAPAJOG<SFXAudioSource>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ObjectPool.LLPPOAPAJOG<SFXAudioSource> IOLNIDMGMEC();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ObjectPool.LLPPOAPAJOG<SFXAudioSource> ABNCKDCKECE();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LCOHCCBKPLJ CLFDLCAIPBC(SFXAudioSource FNBEJKIAEFA, float ICCBNACGHAL, float NDKGEJPCLBH);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Volume")]
		[SerializeField]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8302EE0", Offset = "0x83018E0", VA = "0x188302EE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8302F30", Offset = "0x8301930", VA = "0x188302F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8302E90", Offset = "0x8301890", VA = "0x188302E90")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8302EA0", Offset = "0x83018A0", VA = "0x188302EA0")]
		public RecRoomAudioClip(AudioClip PLAOIBBOMPH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8302DD0", Offset = "0x83017D0", VA = "0x188302DD0")]
		public bool EALFKMAJLNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		protected SFXTrack.PAALINJHDEJ trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8301B20", Offset = "0x8300520", VA = "0x188301B20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SFXTrack.PAALINJHDEJ TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
			get
			{
				return default(SFXTrack.PAALINJHDEJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8301880", Offset = "0x8300280", VA = "0x188301880")]
		protected void JALKFFKMOEE(string CDLCGIGHGJP, SFXTrack.PAALINJHDEJ KCLKPKACMJM, Guid OCONCDFGCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8301A10", Offset = "0x8300410", VA = "0x188301A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8301930", Offset = "0x8300330", VA = "0x188301930", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8301A60", Offset = "0x8300460", VA = "0x188301A60")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAFF3B0", Offset = "0xAFDDB0", VA = "0x180AFF3B0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8302FC0", Offset = "0x83019C0", VA = "0x188302FC0")]
		public void JALKFFKMOEE(string CDLCGIGHGJP, SFXTrack.PAALINJHDEJ KCLKPKACMJM, Guid OCONCDFGCOB, float JJGFBIDFJIK, AssetReference DHOJDOPBGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8301A60", Offset = "0x8300460", VA = "0x188301A60")]
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
		private sealed class EMANGNAAHAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public EMANGNAAHAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83022E0", Offset = "0x8300CE0", VA = "0x1883022E0")]
			internal IEICPJBCMAE<Guid>.OCJLOJGAFAE AEEGGEAGILL(RuntimeAddressableSFXTrack track)
			{
				return default(IEICPJBCMAE<Guid>.OCJLOJGAFAE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private IEICPJBCMAE<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8304D00", Offset = "0x8303700", VA = "0x188304D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEICPJBCMAE<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8304B70", Offset = "0x8303570", VA = "0x188304B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8304800", Offset = "0x8303200", VA = "0x188304800")]
		public AACADPLMCLK<AudioClip> EKDGJJMOFKC(Guid GNMIHKIDINJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8304760", Offset = "0x8303160", VA = "0x188304760")]
		private AACADPLMCLK<AudioClip> EKDGJJMOFKC(AssetReference JAIJJBIPGGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8304AD0", Offset = "0x83034D0", VA = "0x188304AD0")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, FAJBLBHJMMC.HIFBKFBCBLN
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct IPNCKFFIGAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? GEMBJFLENCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? OOGFJCAFFDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Vector3 DHOCNKDECGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Transform PHBJJMANDKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AudioRolloff EANAOMNNEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float EIMLCCBECOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float EFJINJCDLHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public GLPGDNLNMKB? FJEIABBLJCE;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public float FEMBCCJLBMP
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x83024A0", Offset = "0x8300EA0", VA = "0x1883024A0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public GLPGDNLNMKB IIMGJADECIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x8302450", Offset = "0x8300E50", VA = "0x188302450")]
				get
				{
					return default(GLPGDNLNMKB);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct OPLDCFMBIHN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public IPNCKFFIGAP playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83027B0", Offset = "0x83011B0", VA = "0x1883027B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8302D70", Offset = "0x8301770", VA = "0x188302D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class KGKIBCLKCGE : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private JFFMJDIOLAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public KGKIBCLKCGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8302520", Offset = "0x8300F20", VA = "0x188302520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83025A0", Offset = "0x8300FA0", VA = "0x1883025A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Action<SFXAudioSource> KNINMAKEMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private PKHGEDPOIHB JFCCMOGIEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool NGPDNLPIFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JLFIJNDEFBP JDCDFJKAAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private FLLMPDGKPPM ALLAKMJLBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool? POOBNEHFEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float EAOLKBJCKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float POICEJFJGNJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string BNLCCIMLONH = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform PHBJJMANDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource MHDBMCIEGLA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool GFFJFELJGDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8303720", Offset = "0x8302120", VA = "0x188303720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int IJHBJIKOAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8304640", Offset = "0x8303040", VA = "0x188304640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool PFDMKOJACHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8304720", Offset = "0x8303120", VA = "0x188304720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool LGIBEPJECNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8304700", Offset = "0x8303100", VA = "0x188304700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float GEMBJFLENCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8304740", Offset = "0x8303140", VA = "0x188304740")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float LPLAMIMOBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8304660", Offset = "0x8303060", VA = "0x188304660")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8303090", Offset = "0x8301A90", VA = "0x188303090")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8303990", Offset = "0x8302390", VA = "0x188303990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8304560", Offset = "0x8302F60", VA = "0x188304560")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8304540", Offset = "0x8302F40", VA = "0x188304540")]
		public void UpdateVolume(float IKEDDMJNIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8304330", Offset = "0x8302D30", VA = "0x188304330")]
		public void UpdatePitch(float DMDKNLOKEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8304290", Offset = "0x8302C90", VA = "0x188304290")]
		public void UpdateDopplerLevel(float BADFGPNGHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83044A0", Offset = "0x8302EA0", VA = "0x1883044A0")]
		public void UpdateSpatialBlend(float IOBOKCMIKGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83041C0", Offset = "0x8302BC0", VA = "0x1883041C0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8303C70", Offset = "0x8302670", VA = "0x188303C70")]
		public void Play(AudioClip PLAOIBBOMPH, float IKEDDMJNIJO, Vector3 DPIEBKDJHFN, float JECHFGFIOCJ, float FADPIKFJLJG, AudioRolloff EPCIIDCOEMC, [Optional] Action<SFXAudioSource> KIDPALGIBMN, [Optional] EOLJMEJCHDF? FLIDFJKDJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8303B20", Offset = "0x8302520", VA = "0x188303B20")]
		[AsyncStateMachine(typeof(OPLDCFMBIHN))]
		public Task PlayAsync(AudioClip PLAOIBBOMPH, IPNCKFFIGAP KJLANBJKFEA, CancellationToken AHOMALKMHKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8303190", Offset = "0x8301B90", VA = "0x188303190")]
		private void FPMPPPGMMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8303940", Offset = "0x8302340", VA = "0x188303940")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83041F0", Offset = "0x8302BF0", VA = "0x1883041F0")]
		public void Scrub(float LKKNOPLOOPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8304250", Offset = "0x8302C50", VA = "0x188304250")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83040E0", Offset = "0x8302AE0", VA = "0x1883040E0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8304060", Offset = "0x8302A60", VA = "0x188304060")]
		[IteratorStateMachine(typeof(KGKIBCLKCGE))]
		public IEnumerator<JFFMJDIOLAN> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8303180", Offset = "0x8301B80", VA = "0x188303180", Slot = "4")]
		private void DPPFDMGFJJA(bool JNNEMJKMKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
