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
public static class GEHPDHACMJH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x819F940", Offset = "0x819E740", VA = "0x18819F940")]
	public static void MBAFJDEFMBA(this AudioSource AAHEFDPCKCC, AudioRolloff KEBPKGCAECJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GFEDBFKDCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x819FAA0", Offset = "0x819E8A0", VA = "0x18819FAA0")]
	public static float NHLBDCPJKMF(float JKDCAJPJCJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x819FA60", Offset = "0x819E860", VA = "0x18819FA60")]
	public static float JCBJEAECMEH(float BBOJMNOLLOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x819FA00", Offset = "0x819E800", VA = "0x18819FA00")]
	public static float AOOEIHFNOHB(float[] KANAIIDGHCH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[MDLMCBIIKPC]
public enum FLMONBOIJNH : byte
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
		[Cpp2IlInjected.Address(RVA = "0x819F0E0", Offset = "0x819DEE0", VA = "0x18819F0E0")]
		public float NHMBBMLOBKG(float HONJHOGENBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x819F3B0", Offset = "0x819E1B0", VA = "0x18819F3B0")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int FMLBOMGJBLN = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MDLJLDHBBAC<float> NDENGADMLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int HKLNBGKPFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float JBJGOFMAIFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int PLAIOBABOEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x819F7E0", Offset = "0x819E5E0", VA = "0x18819F7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float FPADBJEAKFL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x819F750", Offset = "0x819E550", VA = "0x18819F750")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float FFCBIOJBLEI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x819F720", Offset = "0x819E520", VA = "0x18819F720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDB5D20", Offset = "0xDB4B20", VA = "0x180DB5D20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool KEMIFPDBGMP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x819F3D0", Offset = "0x819E1D0", VA = "0x18819F3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x819F640", Offset = "0x819E440", VA = "0x18819F640")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x819F450", Offset = "0x819E250", VA = "0x18819F450")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x819F690", Offset = "0x819E490", VA = "0x18819F690")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IKFFBFOGBBE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int GPLCHCLELOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, ELPCOELKDGJ> OCOKFPFIPOL();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, ELPCOELKDGJ> PNDKHMFJMBG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, IMAHJEFLABE)> PDKFNFPNNCF();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IMAHJEFLABE PNGBBKFAEHD();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup CGEALGJNNAM(LGJGFMPBMCG BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup BNGOLIABCGG(IMAHJEFLABE BEABNAMJNOB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource OGLACKCFNJB(RecRoomAudioClip BHFAMEFDBDB, Transform CGKEILOCDML, [Optional] AudioRolloff GBIOEHNADCI, [Optional] Action<SFXAudioSource> DOHBHPNFJHM, [Optional] IMAHJEFLABE? BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIFPHIHMBPO(SFXAudioSource FBABCNPBHOI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource IDGKHGMIIHF(RecRoomAudioClip[] HFNHMGEDOGF, bool ODGEDLJIONP = false, float CKPJDBCDEMB = 1f, [Optional] Action<SFXAudioSource> DOHBHPNFJHM, [Optional] IMAHJEFLABE? BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource GNBEKBIOMMP(RecRoomAudioClip[] HFNHMGEDOGF, Transform CGKEILOCDML, [Optional] AudioRolloff GBIOEHNADCI, bool ODGEDLJIONP = false, [Optional] Action<SFXAudioSource> DOHBHPNFJHM, [Optional] IMAHJEFLABE? BHFLBALEEDF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource BKGDDLLCAFK(RecRoomAudioClip CGMKHHOEHNE, Vector3 FABONEEKFMK, [Optional] AudioRolloff GBIOEHNADCI, [Optional] Action<SFXAudioSource> DOHBHPNFJHM, [Optional] IMAHJEFLABE? BHFLBALEEDF, bool EHDFDIHKEMF = false, bool CLNLPLCNPJF = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource EDLIMJLNKHP(RecRoomAudioClip NGLHGCPELMK, [Optional] Action<SFXAudioSource> DOHBHPNFJHM, [Optional] IMAHJEFLABE? BHFLBALEEDF, bool EHDFDIHKEMF = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x819FBD0", Offset = "0x819E9D0", VA = "0x18819FBD0", Slot = "12")]
	ObjectPool.NGCONHBHOIG<SFXAudioSource> PFNBKNKBEFO(bool MDMGCLPLEBJ)
	{
		return default(ObjectPool.NGCONHBHOIG<SFXAudioSource>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ObjectPool.NGCONHBHOIG<SFXAudioSource> LAMJDLGDELA();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ObjectPool.NGCONHBHOIG<SFXAudioSource> IIGBHBOFGFF();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GMJHELKMAKL MKOMJMPODOB(SFXAudioSource FBABCNPBHOI, float NPFIBCFBEJO, float DFOOIFEDPMI);
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
			[Cpp2IlInjected.Address(RVA = "0x81A0460", Offset = "0x819F260", VA = "0x1881A0460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x81A04B0", Offset = "0x819F2B0", VA = "0x1881A04B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81A0410", Offset = "0x819F210", VA = "0x1881A0410")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81A0420", Offset = "0x819F220", VA = "0x1881A0420")]
		public RecRoomAudioClip(AudioClip NGLHGCPELMK)
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
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81A0350", Offset = "0x819F150", VA = "0x1881A0350")]
		public bool LDDIPBBGLMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
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
		protected SFXTrack.NEAECBGMPHE trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x819F0B0", Offset = "0x819DEB0", VA = "0x18819F0B0")]
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
		public SFXTrack.NEAECBGMPHE TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
			get
			{
				return default(SFXTrack.NEAECBGMPHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x819EE10", Offset = "0x819DC10", VA = "0x18819EE10")]
		protected void IBIDIMMJONP(string CGDIPBADIMH, SFXTrack.NEAECBGMPHE HFCGJADJPNC, Guid NMEMPCKPCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x819EFA0", Offset = "0x819DDA0", VA = "0x18819EFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x819EEC0", Offset = "0x819DCC0", VA = "0x18819EEC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x819EFF0", Offset = "0x819DDF0", VA = "0x18819EFF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAE8A00", Offset = "0xAE7800", VA = "0x180AE8A00", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81A0540", Offset = "0x819F340", VA = "0x1881A0540")]
		public void IBIDIMMJONP(string CGDIPBADIMH, SFXTrack.NEAECBGMPHE HFCGJADJPNC, Guid NMEMPCKPCOG, float NKDNPAKABMK, AssetReference AONJLKJFBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x819EFF0", Offset = "0x819DDF0", VA = "0x18819EFF0")]
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
		private sealed class LILBGFBKDPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public LILBGFBKDPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x819FCE0", Offset = "0x819EAE0", VA = "0x18819FCE0")]
			internal EOCLFJJIBDB<Guid>.NDIFJHHBJMD CONADGKGBCN(RuntimeAddressableSFXTrack track)
			{
				return default(EOCLFJJIBDB<Guid>.NDIFJHHBJMD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private EOCLFJJIBDB<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x81A23E0", Offset = "0x81A11E0", VA = "0x1881A23E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EOCLFJJIBDB<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x81A2250", Offset = "0x81A1050", VA = "0x1881A2250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81A1EE0", Offset = "0x81A0CE0", VA = "0x1881A1EE0")]
		public HNDICJJKNNH<AudioClip> GBBBEMOPCOG(Guid DMKCCAHMOIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81A1E40", Offset = "0x81A0C40", VA = "0x1881A1E40")]
		private HNDICJJKNNH<AudioClip> GBBBEMOPCOG(AssetReference MHAPGFOEMPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81A21B0", Offset = "0x81A0FB0", VA = "0x1881A21B0")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, OINEBDKNMFJ.MEHGCMEBBAC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct HDPEBBNFGMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? IHDINCGOIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float? BGMAFHMLHOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Vector3 MHAACPOFGCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Transform DLPPFIDBABP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AudioRolloff GKPIJAHEFDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float NINGGADJKHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float MKAMEBBBGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public LGJGFMPBMCG? LCFEAAEINDH;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public float FNAEHOCMFFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x819FB00", Offset = "0x819E900", VA = "0x18819FB00")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public LGJGFMPBMCG HJOPLOGPCNO
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x819FB80", Offset = "0x819E980", VA = "0x18819FB80")]
				get
				{
					return default(LGJGFMPBMCG);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct MLIOEIBIEFL : IAsyncStateMachine
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
			public HDPEBBNFGMC playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x819FD40", Offset = "0x819EB40", VA = "0x18819FD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x81A02F0", Offset = "0x819F0F0", VA = "0x1881A02F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class CJCILKGEJID : IEnumerator<PHFDFIIIMCE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private PHFDFIIIMCE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private PHFDFIIIMCE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
			[DebuggerHidden]
			public CJCILKGEJID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x819F870", Offset = "0x819E670", VA = "0x18819F870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x819F8F0", Offset = "0x819E6F0", VA = "0x18819F8F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static bool OptimizePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> EINBJCKLBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private MDIEIFNFGHA MPLAPFBBMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool INEAFNJICML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CEDIOCPLCGJ BEGDNPMLPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IKFFBFOGBBE JHFMJAIJECJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool? OABGCCGBFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float FPEIBBLLDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float JKMCMLFKLLO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string NNFHCPOICBA = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform DLPPFIDBABP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource OJDICELOIJF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool IOLCKEDMHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x81A0E00", Offset = "0x819FC00", VA = "0x1881A0E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int JKLEIBPJPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x81A1D20", Offset = "0x81A0B20", VA = "0x1881A1D20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool IADKMMNPFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x81A1E00", Offset = "0x81A0C00", VA = "0x1881A1E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool DMFKDCAGEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x81A1DE0", Offset = "0x81A0BE0", VA = "0x1881A1DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IHDINCGOIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x81A1E20", Offset = "0x81A0C20", VA = "0x1881A1E20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FLOJHCHPACO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x81A1D40", Offset = "0x81A0B40", VA = "0x1881A1D40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81A0D10", Offset = "0x819FB10", VA = "0x1881A0D10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x81A0F50", Offset = "0x819FD50", VA = "0x1881A0F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81A1C40", Offset = "0x81A0A40", VA = "0x1881A1C40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81A1C20", Offset = "0x81A0A20", VA = "0x1881A1C20")]
		public void UpdateVolume(float ILEBLACHCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81A1A20", Offset = "0x81A0820", VA = "0x1881A1A20")]
		public void UpdatePitch(float PIBIKGPEDHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81A1980", Offset = "0x81A0780", VA = "0x1881A1980")]
		public void UpdateDopplerLevel(float OENBMAHHDLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81A1B80", Offset = "0x81A0980", VA = "0x1881A1B80")]
		public void UpdateSpatialBlend(float LGOAGIPDHAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x81A18B0", Offset = "0x81A06B0", VA = "0x1881A18B0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81A1230", Offset = "0x81A0030", VA = "0x1881A1230")]
		public void Play(AudioClip NGLHGCPELMK, float ILEBLACHCBE, Vector3 FABONEEKFMK, float LGBGCGLDOIK, float OKLPCPENPLB, AudioRolloff KEBPKGCAECJ, [Optional] Action<SFXAudioSource> GHMOAJNPGEG, [Optional] IMAHJEFLABE? BHFLBALEEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81A10E0", Offset = "0x819FEE0", VA = "0x1881A10E0")]
		[AsyncStateMachine(typeof(MLIOEIBIEFL))]
		public Task PlayAsync(AudioClip NGLHGCPELMK, HDPEBBNFGMC CJOEOOHNGPP, CancellationToken BKHGNHANFKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81A0610", Offset = "0x819F410", VA = "0x1881A0610")]
		private void AHFHGLGMONH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81A0F00", Offset = "0x819FD00", VA = "0x1881A0F00")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81A18E0", Offset = "0x81A06E0", VA = "0x1881A18E0")]
		public void Scrub(float GJEDFMHCPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81A1940", Offset = "0x81A0740", VA = "0x1881A1940")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81A17D0", Offset = "0x81A05D0", VA = "0x1881A17D0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81A1750", Offset = "0x81A0550", VA = "0x1881A1750")]
		[IteratorStateMachine(typeof(CJCILKGEJID))]
		public IEnumerator<PHFDFIIIMCE> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81A0EF0", Offset = "0x819FCF0", VA = "0x1881A0EF0", Slot = "4")]
		private void INCFIONLJAK(bool HEPPDGLDFNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
