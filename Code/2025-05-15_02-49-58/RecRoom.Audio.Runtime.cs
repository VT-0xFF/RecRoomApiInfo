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
public static class MLADBHHMCOC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A5B810", Offset = "0x7A59E10", VA = "0x187A5B810")]
	public static void OELOHLIBBCF(this AudioSource CPAHCCAGBHF, AudioRolloff MJEKODDCILF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HEDOJFOFGAA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A5B510", Offset = "0x7A59B10", VA = "0x187A5B510")]
	public static float ECNBGELCHGO(float IFAACIIGLMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A5B5D0", Offset = "0x7A59BD0", VA = "0x187A5B5D0")]
	public static float LIJCFBFELAH(float GAEEMHDINEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7A5B570", Offset = "0x7A59B70", VA = "0x187A5B570")]
	public static float JBCONKCGEID(float[] APDBNIMCPID)
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

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AD80", Offset = "0x7A59380", VA = "0x187A5AD80")]
		public float FNFHMFPLBLJ(float PHOKMKANBFJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B050", Offset = "0x7A59650", VA = "0x187A5B050")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int FNKOMMEMDKN = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private COCLBOJKODC<float> DJBEIALIAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BPAOHJEKIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float CNOOBEIAKHG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ILCODFKELCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B480", Offset = "0x7A59A80", VA = "0x187A5B480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float MLBCIHIAOHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B3F0", Offset = "0x7A599F0", VA = "0x187A5B3F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float MNHDIGHIGIF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B3C0", Offset = "0x7A599C0", VA = "0x187A5B3C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC55220", Offset = "0xC53820", VA = "0x180C55220")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool JHACCPBODGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B070", Offset = "0x7A59670", VA = "0x187A5B070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B2E0", Offset = "0x7A598E0", VA = "0x187A5B2E0")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B0F0", Offset = "0x7A596F0", VA = "0x187A5B0F0")]
		private void OnAudioFilterRead(float[] APDBNIMCPID, int MBHMJBOMGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5B330", Offset = "0x7A59930", VA = "0x187A5B330")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HILIJPLMOBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int GGLJAMOCLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, FDEEMEDLPLM> HDAMDGDONNF();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, FDEEMEDLPLM> AIFECFLJANM();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, MGOADJAIONL)> GHHLNBFPCPO();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGOADJAIONL FHMEBCMPNHD();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup AFHHHJPGCAB(AKPEMBBLIEK DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup GJIIAJLNPDK(MGOADJAIONL HOCEOKPMDNM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource NPFMHCGHIKI(RecRoomAudioClip EKDHDCFOPOG, Transform OOLHKMJOAEL, [Optional] AudioRolloff LJJCKBGEKIF, [Optional] Action<SFXAudioSource> AABLKBJLNMJ, [Optional] MGOADJAIONL? DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FEPIFCDCFHJ(SFXAudioSource MODNOFLEKJF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource NOLIGBBJLHP(RecRoomAudioClip[] OFJOOJMHBAJ, bool BGMFDFKBDKE = false, float FMKHKGPLANJ = 1f, [Optional] Action<SFXAudioSource> AABLKBJLNMJ, [Optional] MGOADJAIONL? DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource GDJMOEICDOC(RecRoomAudioClip[] OFJOOJMHBAJ, Transform OOLHKMJOAEL, [Optional] AudioRolloff LJJCKBGEKIF, bool BGMFDFKBDKE = false, [Optional] Action<SFXAudioSource> AABLKBJLNMJ, [Optional] MGOADJAIONL? DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource JPHBODHJAGD(RecRoomAudioClip AAPBDGBEADC, Vector3 DJHCIGKJNEI, [Optional] AudioRolloff LJJCKBGEKIF, [Optional] Action<SFXAudioSource> AABLKBJLNMJ, [Optional] MGOADJAIONL? DHLCHOOBMKM, bool NPCGMBJKNBK = false, bool FDMDNBEDIKO = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource OKKPMNKFOAN(RecRoomAudioClip HKBGHCOEAAP, [Optional] Action<SFXAudioSource> AABLKBJLNMJ, [Optional] MGOADJAIONL? DHLCHOOBMKM, bool NPCGMBJKNBK = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OLILOOIADED GAAKMEHDIGB(SFXAudioSource MODNOFLEKJF, float MGCMHLABPEK, float JHNMLGDIFJL);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Header("Volume")]
		[SerializeField]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7A5BFF0", Offset = "0x7A5A5F0", VA = "0x187A5BFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C040", Offset = "0x7A5A640", VA = "0x187A5C040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BFA0", Offset = "0x7A5A5A0", VA = "0x187A5BFA0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BFB0", Offset = "0x7A5A5B0", VA = "0x187A5BFB0")]
		public RecRoomAudioClip(AudioClip HKBGHCOEAAP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7A5BEE0", Offset = "0x7A5A4E0", VA = "0x187A5BEE0")]
		public bool EBOAHGMBEJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		protected SFXTrack.AJHPBGIKAJL trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A5AD50", Offset = "0x7A59350", VA = "0x187A5AD50")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SFXTrack.AJHPBGIKAJL TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			get
			{
				return default(SFXTrack.AJHPBGIKAJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AAB0", Offset = "0x7A590B0", VA = "0x187A5AAB0")]
		protected void GNPHCEILENM(string OMCLCFINMNI, SFXTrack.AJHPBGIKAJL PMFEFFPLIMC, Guid DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AC40", Offset = "0x7A59240", VA = "0x187A5AC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AB60", Offset = "0x7A59160", VA = "0x187A5AB60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AC90", Offset = "0x7A59290", VA = "0x187A5AC90")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC07340", Offset = "0xC05940", VA = "0x180C07340", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C0D0", Offset = "0x7A5A6D0", VA = "0x187A5C0D0")]
		public void GNPHCEILENM(string OMCLCFINMNI, SFXTrack.AJHPBGIKAJL PMFEFFPLIMC, Guid DGNNPFFMIEE, float HIMLJPEKLNP, AssetReference LJCCCIBDJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7A5AC90", Offset = "0x7A59290", VA = "0x187A5AC90")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class LKLJHGPPGNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public LKLJHGPPGNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B7B0", Offset = "0x7A59DB0", VA = "0x187A5B7B0")]
			internal HOBCNHIEEIJ<Guid>.HOFJAOLMJEK DHPDBIJFMAE(RuntimeAddressableSFXTrack track)
			{
				return default(HOBCNHIEEIJ<Guid>.HOFJAOLMJEK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HOBCNHIEEIJ<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7A5DF70", Offset = "0x7A5C570", VA = "0x187A5DF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HOBCNHIEEIJ<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7A5DDE0", Offset = "0x7A5C3E0", VA = "0x187A5DDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D9D0", Offset = "0x7A5BFD0", VA = "0x187A5D9D0")]
		public GKHPBLLBAIL<AudioClip> PINKNICFHLK(Guid MDMKJJADGEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DCA0", Offset = "0x7A5C2A0", VA = "0x187A5DCA0")]
		private GKHPBLLBAIL<AudioClip> PINKNICFHLK(AssetReference OCPDOAABMBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7A5DD40", Offset = "0x7A5C340", VA = "0x187A5DD40")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, MCNFNJGPLLN.CHGAENCDGCM
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct JFDFALENCDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float? DIALMNIMGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? HKCNAECOIFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Vector3 JEJBDMNPGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Transform EAGMFBNKHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AudioRolloff GHHCGCJNBJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public float HBGHDLNKGNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float LHIHJMGPEMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public AKPEMBBLIEK? JCJACEFDCOK;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public float KHPOBKBEMDI
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x7A5B660", Offset = "0x7A59C60", VA = "0x187A5B660")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public AKPEMBBLIEK BNPPNFEIPGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7A5B610", Offset = "0x7A59C10", VA = "0x187A5B610")]
				get
				{
					return default(AKPEMBBLIEK);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct PIDAKKGEPLC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public JFDFALENCDL playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B8D0", Offset = "0x7A59ED0", VA = "0x187A5B8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7A5BE80", Offset = "0x7A5A480", VA = "0x187A5BE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JHLNBFGHLIC : IEnumerator<NFNODNEANBN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private NFNODNEANBN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private NFNODNEANBN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
			[DebuggerHidden]
			public JHLNBFGHLIC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B6E0", Offset = "0x7A59CE0", VA = "0x187A5B6E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7A5B760", Offset = "0x7A59D60", VA = "0x187A5B760", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static bool OptimizePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Action<SFXAudioSource> POKFAKGLIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private ALBMIKCECHI FCHAKBIEGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DAOPCAAKCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JAHOCBPGMLL MKIEJCFADMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private HILIJPLMOBJ HOHDBFPNFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool? JMDEGAMJGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float HBMAKJNFBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float OALEMBOCIFE;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string DGJGDEJCGED = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform EAGMFBNKHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool HCAPMPIBFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7A5C290", Offset = "0x7A5A890", VA = "0x187A5C290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DOKEPICAELM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D8B0", Offset = "0x7A5BEB0", VA = "0x187A5D8B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NKPHOCFBMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D990", Offset = "0x7A5BF90", VA = "0x187A5D990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HMDJJMGNHLC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D970", Offset = "0x7A5BF70", VA = "0x187A5D970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DIALMNIMGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D9B0", Offset = "0x7A5BFB0", VA = "0x187A5D9B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ABCDFNAMCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7A5D8D0", Offset = "0x7A5BED0", VA = "0x187A5D8D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C1A0", Offset = "0x7A5A7A0", VA = "0x187A5C1A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CAE0", Offset = "0x7A5B0E0", VA = "0x187A5CAE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D7D0", Offset = "0x7A5BDD0", VA = "0x187A5D7D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D7B0", Offset = "0x7A5BDB0", VA = "0x187A5D7B0")]
		public void UpdateVolume(float HMNMGHAHLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D5B0", Offset = "0x7A5BBB0", VA = "0x187A5D5B0")]
		public void UpdatePitch(float NADKHIGBGGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D510", Offset = "0x7A5BB10", VA = "0x187A5D510")]
		public void UpdateDopplerLevel(float IEPFPMHJJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D710", Offset = "0x7A5BD10", VA = "0x187A5D710")]
		public void UpdateSpatialBlend(float MNLNFMNLKMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D440", Offset = "0x7A5BA40", VA = "0x187A5D440")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CDC0", Offset = "0x7A5B3C0", VA = "0x187A5CDC0")]
		public void Play(AudioClip HKBGHCOEAAP, float HMNMGHAHLLN, Vector3 DJHCIGKJNEI, float IDCPJCKNALI, float OFHBKICKNDO, AudioRolloff MJEKODDCILF, [Optional] Action<SFXAudioSource> GAFKDBBOOCH, [Optional] MGOADJAIONL? DHLCHOOBMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A5CC70", Offset = "0x7A5B270", VA = "0x187A5CC70")]
		[AsyncStateMachine(typeof(PIDAKKGEPLC))]
		public Task PlayAsync(AudioClip HKBGHCOEAAP, JFDFALENCDL KMGICFJDLOA, CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C3E0", Offset = "0x7A5A9E0", VA = "0x187A5C3E0")]
		private void NKDGPPKODGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C390", Offset = "0x7A5A990", VA = "0x187A5C390")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D470", Offset = "0x7A5BA70", VA = "0x187A5D470")]
		public void Scrub(float EPGNCELGAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D4D0", Offset = "0x7A5BAD0", VA = "0x187A5D4D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D360", Offset = "0x7A5B960", VA = "0x187A5D360")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7A5D2E0", Offset = "0x7A5B8E0", VA = "0x187A5D2E0")]
		[IteratorStateMachine(typeof(JHLNBFGHLIC))]
		public IEnumerator<NFNODNEANBN> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7A5C380", Offset = "0x7A5A980", VA = "0x187A5C380", Slot = "4")]
		private void HCEOKJAPLCG(bool CBHHPIGGAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
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
