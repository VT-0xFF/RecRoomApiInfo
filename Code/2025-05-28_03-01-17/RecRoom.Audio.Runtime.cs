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
public static class OOBEPJNGAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4490", Offset = "0x7BC3290", VA = "0x187BC4490")]
	public static void LLLDFAIIBLM(this AudioSource PAGHKLDONAI, AudioRolloff BPGMOPBLCFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PPEIGNJCJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4590", Offset = "0x7BC3390", VA = "0x187BC4590")]
	public static float FACALAEGMGP(float CCHLMJCLNBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4550", Offset = "0x7BC3350", VA = "0x187BC4550")]
	public static float DKCIJCONNNF(float MAMACJMIMDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7BC45F0", Offset = "0x7BC33F0", VA = "0x187BC45F0")]
	public static float HNHEOOJEHJN(float[] FFEMKICJPKP)
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
		[Cpp2IlInjected.Address(RVA = "0x7BC34E0", Offset = "0x7BC22E0", VA = "0x187BC34E0")]
		public float GIKIOIHIEAC(float LBNEPEMBBNG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BC37B0", Offset = "0x7BC25B0", VA = "0x187BC37B0")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int EJLCECCFGPP = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private LLLPPDPKBDD<float> FMBAJAGBEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int BEEBMHDJNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float PDFIBFIHPAG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int MHLINHFECAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3BE0", Offset = "0x7BC29E0", VA = "0x187BC3BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LIFPNEHKLJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3B50", Offset = "0x7BC2950", VA = "0x187BC3B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float ENIGALNJACB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3B20", Offset = "0x7BC2920", VA = "0x187BC3B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xC77DA0", Offset = "0xC76BA0", VA = "0x180C77DA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool PGNFNNJCJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC37D0", Offset = "0x7BC25D0", VA = "0x187BC37D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3A40", Offset = "0x7BC2840", VA = "0x187BC3A40")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3850", Offset = "0x7BC2650", VA = "0x187BC3850")]
		private void OnAudioFilterRead(float[] FFEMKICJPKP, int CPCMKMKKGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3A90", Offset = "0x7BC2890", VA = "0x187BC3A90")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FBGCCCAKCNK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int CCCAGCBLBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, FIBJHCAOCDK> IOMABJPLIJC();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, FIBJHCAOCDK> DHEHLFJFGFM();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, PFINJACLFHC)> GHLBGJKABDH();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PFINJACLFHC JAOAJDOPIHN();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup GKENEKHPKPI(FKDFENLAEMP ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup JKGNLLLNBDA(PFINJACLFHC IHDGIPHCDKK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource BKJGNAMBMBE(RecRoomAudioClip EBFNINDMGMJ, Transform MPPCGLHPBEP, [Optional] AudioRolloff EEOPMGNIDPA, [Optional] Action<SFXAudioSource> HDHBKLDKPPC, [Optional] PFINJACLFHC? ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KBKEFKADCJE(SFXAudioSource CEEKEJPIJMG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource LGBPFFIPPIC(RecRoomAudioClip[] KLCCNMCNEHP, bool ECGMFMLNMPK = false, float MHGDHCKAAJJ = 1f, [Optional] Action<SFXAudioSource> HDHBKLDKPPC, [Optional] PFINJACLFHC? ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource GOPPAMAGEOG(RecRoomAudioClip[] KLCCNMCNEHP, Transform MPPCGLHPBEP, [Optional] AudioRolloff EEOPMGNIDPA, bool ECGMFMLNMPK = false, [Optional] Action<SFXAudioSource> HDHBKLDKPPC, [Optional] PFINJACLFHC? ONKHCNLCBAI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource JEFMKFKINMP(RecRoomAudioClip OPDCDPDFEPA, Vector3 PLKCLDLMLHK, [Optional] AudioRolloff EEOPMGNIDPA, [Optional] Action<SFXAudioSource> HDHBKLDKPPC, [Optional] PFINJACLFHC? ONKHCNLCBAI, bool COGBEANHMFN = false, bool FFNGDDIHBFP = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource PKJBBJMNLBP(RecRoomAudioClip CLPJJKCGMPB, [Optional] Action<SFXAudioSource> HDHBKLDKPPC, [Optional] PFINJACLFHC? ONKHCNLCBAI, bool COGBEANHMFN = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BGLABEGMMJM KMEIPDNANIC(SFXAudioSource CEEKEJPIJMG, float ALOBCOBBAPC, float NFGIPBFMCLH);
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
			[Cpp2IlInjected.Address(RVA = "0x7BC4760", Offset = "0x7BC3560", VA = "0x187BC4760")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC47B0", Offset = "0x7BC35B0", VA = "0x187BC47B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4710", Offset = "0x7BC3510", VA = "0x187BC4710")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4720", Offset = "0x7BC3520", VA = "0x187BC4720")]
		public RecRoomAudioClip(AudioClip CLPJJKCGMPB)
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4650", Offset = "0x7BC3450", VA = "0x187BC4650")]
		public bool EFIPIKFLEGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xBD1A10", Offset = "0xBD0810", VA = "0x180BD1A10")]
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
		protected SFXTrack.PPCNBHALEDP trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7BC34B0", Offset = "0x7BC22B0", VA = "0x187BC34B0")]
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
		public SFXTrack.PPCNBHALEDP TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			get
			{
				return default(SFXTrack.PPCNBHALEDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3210", Offset = "0x7BC2010", VA = "0x187BC3210")]
		protected void BEEGBCAKKKO(string DCBGPPPDNMF, SFXTrack.PPCNBHALEDP LFMKDODPCKA, Guid PDFBNFKDLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC33A0", Offset = "0x7BC21A0", VA = "0x187BC33A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC32C0", Offset = "0x7BC20C0", VA = "0x187BC32C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC33F0", Offset = "0x7BC21F0", VA = "0x187BC33F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xC27EC0", Offset = "0xC26CC0", VA = "0x180C27EC0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4840", Offset = "0x7BC3640", VA = "0x187BC4840")]
		public void BEEGBCAKKKO(string DCBGPPPDNMF, SFXTrack.PPCNBHALEDP LFMKDODPCKA, Guid PDFBNFKDLAH, float NFCOMAHDKCD, AssetReference EDMBGOHEOOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BC33F0", Offset = "0x7BC21F0", VA = "0x187BC33F0")]
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
		private sealed class HBPPHIFACMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HBPPHIFACMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3C70", Offset = "0x7BC2A70", VA = "0x187BC3C70")]
			internal DDIMECLAJGG<Guid>.MDOIDPCDIBD IAGFOFMPKHD(RuntimeAddressableSFXTrack track)
			{
				return default(DDIMECLAJGG<Guid>.MDOIDPCDIBD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DDIMECLAJGG<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BC66F0", Offset = "0x7BC54F0", VA = "0x187BC66F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DDIMECLAJGG<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BC6560", Offset = "0x7BC5360", VA = "0x187BC6560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6150", Offset = "0x7BC4F50", VA = "0x187BC6150")]
		public EHIFMMNJMNN<AudioClip> AHMGFAFJNCH(Guid NAGEDDMDOGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6420", Offset = "0x7BC5220", VA = "0x187BC6420")]
		private EHIFMMNJMNN<AudioClip> AHMGFAFJNCH(AssetReference GOMOPJCFAHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BC64C0", Offset = "0x7BC52C0", VA = "0x187BC64C0")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, DNDDHCPOIHB.MNKCIIIPEON
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OEHMGCCHHBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float? JBALPEJNMPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? JJKCCMBJMNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Vector3 OBHFHPJIJAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Transform KFLDFEBMJJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AudioRolloff KIILEIPGEEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public float KAGJBANBDHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float MPMDKPFMHJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FKDFENLAEMP? CCBNHJOJPAA;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public float CHDBDNOCNMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x7BC3DF0", Offset = "0x7BC2BF0", VA = "0x187BC3DF0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public FKDFENLAEMP PLINDDDAFJH
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7BC3DA0", Offset = "0x7BC2BA0", VA = "0x187BC3DA0")]
				get
				{
					return default(FKDFENLAEMP);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct OLJHPPOKHOL : IAsyncStateMachine
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
			public OEHMGCCHHBB playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x7BC3E70", Offset = "0x7BC2C70", VA = "0x187BC3E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BC4430", Offset = "0x7BC3230", VA = "0x187BC4430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KCMLHDCEIHM : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private GCOFLMDGPIM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public KCMLHDCEIHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3CD0", Offset = "0x7BC2AD0", VA = "0x187BC3CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC3D50", Offset = "0x7BC2B50", VA = "0x187BC3D50", Slot = "8")]
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
		private Action<SFXAudioSource> LFIENHNFPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private OJJOHCMLHDB PNNGHKDKGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool BKPKBKKHPHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IPJEPIMCHKK NHPBAKKHNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private FBGCCCAKCNK KOKGKMFIFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool? HADACEHJFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float LMBBPHICJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float DHCDIBFKPPL;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string OOMHNHECLJO = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform KFLDFEBMJJL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool DHLKOIOKGOK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC4910", Offset = "0x7BC3710", VA = "0x187BC4910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int NHLKNJDKDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC6030", Offset = "0x7BC4E30", VA = "0x187BC6030")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IGFLPNHONHF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BC6110", Offset = "0x7BC4F10", VA = "0x187BC6110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool HGABLALEECO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC60F0", Offset = "0x7BC4EF0", VA = "0x187BC60F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JBALPEJNMPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7BC6130", Offset = "0x7BC4F30", VA = "0x187BC6130")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float MBEHLMFOAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7BC6050", Offset = "0x7BC4E50", VA = "0x187BC6050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4A00", Offset = "0x7BC3800", VA = "0x187BC4A00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5250", Offset = "0x7BC4050", VA = "0x187BC5250")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5F50", Offset = "0x7BC4D50", VA = "0x187BC5F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5F30", Offset = "0x7BC4D30", VA = "0x187BC5F30")]
		public void UpdateVolume(float FOKIKDJOADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5D20", Offset = "0x7BC4B20", VA = "0x187BC5D20")]
		public void UpdatePitch(float IMEKAKBNPBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5C80", Offset = "0x7BC4A80", VA = "0x187BC5C80")]
		public void UpdateDopplerLevel(float MCBGJLIHHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5E90", Offset = "0x7BC4C90", VA = "0x187BC5E90")]
		public void UpdateSpatialBlend(float MPJOALEMNMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5BB0", Offset = "0x7BC49B0", VA = "0x187BC5BB0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5530", Offset = "0x7BC4330", VA = "0x187BC5530")]
		public void Play(AudioClip CLPJJKCGMPB, float FOKIKDJOADB, Vector3 PLKCLDLMLHK, float AHINIALMDNO, float GKIBJOMDHKN, AudioRolloff BPGMOPBLCFG, [Optional] Action<SFXAudioSource> LMEFBIHMAGB, [Optional] PFINJACLFHC? ONKHCNLCBAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC53E0", Offset = "0x7BC41E0", VA = "0x187BC53E0")]
		[AsyncStateMachine(typeof(OLJHPPOKHOL))]
		public Task PlayAsync(AudioClip CLPJJKCGMPB, OEHMGCCHHBB FGNDIBKCMNM, CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4B00", Offset = "0x7BC3900", VA = "0x187BC4B00")]
		private void KFOLJHHOBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5200", Offset = "0x7BC4000", VA = "0x187BC5200")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5BE0", Offset = "0x7BC49E0", VA = "0x187BC5BE0")]
		public void Scrub(float CKLBNPGGJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5C40", Offset = "0x7BC4A40", VA = "0x187BC5C40")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5AD0", Offset = "0x7BC48D0", VA = "0x187BC5AD0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5A50", Offset = "0x7BC4850", VA = "0x187BC5A50")]
		[IteratorStateMachine(typeof(KCMLHDCEIHM))]
		public IEnumerator<GCOFLMDGPIM> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BC4AF0", Offset = "0x7BC38F0", VA = "0x187BC4AF0", Slot = "4")]
		private void HBLMFIEDHED(bool DLKFMHELCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
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
