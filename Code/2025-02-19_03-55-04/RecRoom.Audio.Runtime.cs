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
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INBBDNKHGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72EECE0", Offset = "0x72ED8E0", VA = "0x1872EECE0")]
	public static void AOAPBLIJCFM(this AudioSource MLNHPNEGJDO, AudioRolloff KFOKMOKKKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PNOPMMMAGDE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72EF410", Offset = "0x72EE010", VA = "0x1872EF410")]
	public static float ELCFFEGIAMP(float LLLIBGLNHFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72EF470", Offset = "0x72EE070", VA = "0x1872EF470")]
	public static float HOMBDIAHPPA(float INCLKNIHDBD)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72EE850", Offset = "0x72ED450", VA = "0x1872EE850")]
		public float EKPCNPJFOHJ(float DKJIEPCIPIF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72EEB20", Offset = "0x72ED720", VA = "0x1872EEB20")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JJIDJNIPBCA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int EOEBNAAODJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, JJHGKOMIDDI> DAKMFDKCEOF();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, JJHGKOMIDDI> NCNFBDAAPFK();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, KPJLOFILBEP)> NNPENKOFBPM();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPJLOFILBEP MKALFMFGBLO();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup JOHBFENICAJ(PPKKPDPOIBC HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup LAEHKOLNHDE(KPJLOFILBEP MPJCNJDEEOB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource PPLJHPOGGOC(RecRoomAudioClip PNEELABHBDE, Transform APEHJGPDCDN, [Optional] AudioRolloff BDMEMGPBBHO, [Optional] Action<SFXAudioSource> KMNCOIEOMLD, [Optional] KPJLOFILBEP? HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CLFEOICMAGI(SFXAudioSource OMFFJEIDBON);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource JGGOMFHCLPG(RecRoomAudioClip[] IDCOFCGCLOP, bool AGMHGEPDPGK = false, float DCAHKKAKGOB = 1f, [Optional] Action<SFXAudioSource> KMNCOIEOMLD, [Optional] KPJLOFILBEP? HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource CADCLDAKHFP(RecRoomAudioClip[] IDCOFCGCLOP, Transform APEHJGPDCDN, [Optional] AudioRolloff BDMEMGPBBHO, bool AGMHGEPDPGK = false, [Optional] Action<SFXAudioSource> KMNCOIEOMLD, [Optional] KPJLOFILBEP? HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource IOFLKMJACDF(RecRoomAudioClip DFBBAODFMLK, Vector3 LMLKPPMEPBH, bool KEBFHHPPBKB, [Optional] AudioRolloff BDMEMGPBBHO, [Optional] Action<SFXAudioSource> KMNCOIEOMLD, [Optional] KPJLOFILBEP? HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource DOFHDOIMEKL(RecRoomAudioClip NKPJCIFFFLF, [Optional] Action<SFXAudioSource> KMNCOIEOMLD, [Optional] KPJLOFILBEP? HKGEDMGHELN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NAEMDCMJKFJ FNAOFKEEAAN(SFXAudioSource OMFFJEIDBON, float AGKICPMPPML, float ALPIBOHIFKI);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Pitch")]
		[Range(0f, 2f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x72EF5C0", Offset = "0x72EE1C0", VA = "0x1872EF5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72EF610", Offset = "0x72EE210", VA = "0x1872EF610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72EF570", Offset = "0x72EE170", VA = "0x1872EF570")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72EF580", Offset = "0x72EE180", VA = "0x1872EF580")]
		public RecRoomAudioClip(AudioClip NKPJCIFFFLF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72EF4B0", Offset = "0x72EE0B0", VA = "0x1872EF4B0")]
		public bool PGOHFFBNMPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4A930", Offset = "0xA49530", VA = "0x180A4A930")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		protected SFXTrack.HMGBGCPJJBG trackType;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72EE820", Offset = "0x72ED420", VA = "0x1872EE820")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SFXTrack.HMGBGCPJJBG TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840")]
			get
			{
				return default(SFXTrack.HMGBGCPJJBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72EE580", Offset = "0x72ED180", VA = "0x1872EE580")]
		protected void AEMFLOCLMMJ(string MFFNGHBBOHO, SFXTrack.HMGBGCPJJBG KGOFAMNLKAD, Guid IEIMOIIMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72EE710", Offset = "0x72ED310", VA = "0x1872EE710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72EE630", Offset = "0x72ED230", VA = "0x1872EE630", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72EE760", Offset = "0x72ED360", VA = "0x1872EE760")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA9DDF0", Offset = "0xA9C9F0", VA = "0x180A9DDF0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72EF6A0", Offset = "0x72EE2A0", VA = "0x1872EF6A0")]
		public void AEMFLOCLMMJ(string MFFNGHBBOHO, SFXTrack.HMGBGCPJJBG KGOFAMNLKAD, Guid IEIMOIIMGDN, float PLHMGHBGKAK, AssetReference OIEJJIOJOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72EE760", Offset = "0x72ED360", VA = "0x1872EE760")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KLJPPKMOHBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public KLJPPKMOHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x72EEDA0", Offset = "0x72ED9A0", VA = "0x1872EEDA0")]
			internal ILLEABLABNC<Guid>.GGJKIIPAEMJ FNOALILHDNP(RuntimeAddressableSFXTrack track)
			{
				return default(ILLEABLABNC<Guid>.GGJKIIPAEMJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private ILLEABLABNC<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x72F1550", Offset = "0x72F0150", VA = "0x1872F1550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ILLEABLABNC<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x72F13C0", Offset = "0x72EFFC0", VA = "0x1872F13C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72F0FB0", Offset = "0x72EFBB0", VA = "0x1872F0FB0")]
		public OBLFPJIHAJD<AudioClip> CJNGPLCCFHB(Guid EGGDDLOMGHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72F1280", Offset = "0x72EFE80", VA = "0x1872F1280")]
		private OBLFPJIHAJD<AudioClip> CJNGPLCCFHB(AssetReference PEJGIPNGFEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72F1320", Offset = "0x72EFF20", VA = "0x1872F1320")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXAudioSource : MonoBehaviour, NAGCDCIBHBC.LPNANMNMECO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct CFENCIEJELM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public float? NNPKCMPLHKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float? ADFHPFHKMHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public Vector3 NFMPBNMALGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Transform BMMABIBBCGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AudioRolloff LNHFEEEMDND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float MECGLPGKCBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float HIBAGHNPFIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public PPKKPDPOIBC? GOAIAPMGIFD;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public float GHKENCBHJKE
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x72EEC60", Offset = "0x72ED860", VA = "0x1872EEC60")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public PPKKPDPOIBC DHHANPJNEGF
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x72EEC10", Offset = "0x72ED810", VA = "0x1872EEC10")]
				get
				{
					return default(PPKKPDPOIBC);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct LDODIJBDGJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public CFENCIEJELM playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x72EEE00", Offset = "0x72EDA00", VA = "0x1872EEE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72EF3B0", Offset = "0x72EDFB0", VA = "0x1872EF3B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BBDKAFGONOF : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public BBDKAFGONOF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x72EEB40", Offset = "0x72ED740", VA = "0x1872EEB40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72EEBC0", Offset = "0x72ED7C0", VA = "0x1872EEBC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static bool OptimizePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Action<SFXAudioSource> HGCJOJEJNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private FIJFJANJAHF PADLIFHINIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool BPIOPCPNMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private DEECLODLFLE PGNOLMGOHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private JJIDJNIPBCA PCDIMJKBCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? IHIJBCOMIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float HFLKJLAMCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private float NCNDBFFOKKH;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const string FIJOLMOJGDM = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Transform BMMABIBBCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool LDAHEEKFGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x72F0160", Offset = "0x72EED60", VA = "0x1872F0160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int BJONHMAFOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72F0E90", Offset = "0x72EFA90", VA = "0x1872F0E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KICAEKFLJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x72F0F70", Offset = "0x72EFB70", VA = "0x1872F0F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OMNNJMBINGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x72F0F50", Offset = "0x72EFB50", VA = "0x1872F0F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float NNPKCMPLHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72F0F90", Offset = "0x72EFB90", VA = "0x1872F0F90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float OBPPHGANFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72F0EB0", Offset = "0x72EFAB0", VA = "0x1872F0EB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72EFE80", Offset = "0x72EEA80", VA = "0x1872EFE80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72EFFD0", Offset = "0x72EEBD0", VA = "0x1872EFFD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72F0DB0", Offset = "0x72EF9B0", VA = "0x1872F0DB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72F0D90", Offset = "0x72EF990", VA = "0x1872F0D90")]
		public void UpdateVolume(float CBMMCBAFLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72F0B90", Offset = "0x72EF790", VA = "0x1872F0B90")]
		public void UpdatePitch(float BEKDCPBKMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72F0AF0", Offset = "0x72EF6F0", VA = "0x1872F0AF0")]
		public void UpdateDopplerLevel(float EOJFMCMHGFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72F0CF0", Offset = "0x72EF8F0", VA = "0x1872F0CF0")]
		public void UpdateSpatialBlend(float GKKKDFIALOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72F0A20", Offset = "0x72EF620", VA = "0x1872F0A20")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x72F03A0", Offset = "0x72EEFA0", VA = "0x1872F03A0")]
		public void Play(AudioClip NKPJCIFFFLF, float CBMMCBAFLNC, Vector3 LMLKPPMEPBH, float FJKPNADOAIE, float LFKLJGDELBB, AudioRolloff KFOKMOKKKPB, [Optional] Action<SFXAudioSource> DGFHOAIPLCK, [Optional] KPJLOFILBEP? HKGEDMGHELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72F0250", Offset = "0x72EEE50", VA = "0x1872F0250")]
		[AsyncStateMachine(typeof(LDODIJBDGJC))]
		public Task PlayAsync(AudioClip NKPJCIFFFLF, CFENCIEJELM OIKJAGILIMF, CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72EF770", Offset = "0x72EE370", VA = "0x1872EF770")]
		private void APDKOCGIDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72EFF70", Offset = "0x72EEB70", VA = "0x1872EFF70")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72F0A50", Offset = "0x72EF650", VA = "0x1872F0A50")]
		public void Scrub(float MKKLKGKOEPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72F0AB0", Offset = "0x72EF6B0", VA = "0x1872F0AB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72F0940", Offset = "0x72EF540", VA = "0x1872F0940")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72F08C0", Offset = "0x72EF4C0", VA = "0x1872F08C0")]
		[IteratorStateMachine(typeof(BBDKAFGONOF))]
		public IEnumerator<LNKBBFODFEI> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72EFFC0", Offset = "0x72EEBC0", VA = "0x1872EFFC0", Slot = "4")]
		private void NPGOCAKIHIO(bool LBOHKFHGEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
