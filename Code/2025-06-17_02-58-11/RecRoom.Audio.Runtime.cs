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
public static class IFADMDJBNBH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FB60", Offset = "0x7B6E560", VA = "0x187B6FB60")]
	public static void FGOANBOGGLB(this AudioSource KEPBGHONCEB, AudioRolloff JDKACBOPDBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NCGMHMJHMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FE20", Offset = "0x7B6E820", VA = "0x187B6FE20")]
	public static float APIFANMPAFH(float FMHEJIOMGMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FEE0", Offset = "0x7B6E8E0", VA = "0x187B6FEE0")]
	public static float PLIDGFDNOGJ(float BPCJPNIIAEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FE80", Offset = "0x7B6E880", VA = "0x187B6FE80")]
	public static float LFJMGDNDNNO(float[] HPGIDELCODH)
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
		[Cpp2IlInjected.Address(RVA = "0x7B6EDC0", Offset = "0x7B6D7C0", VA = "0x187B6EDC0")]
		public float HBPPMNFGHBA(float NJGJECBFPKC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F090", Offset = "0x7B6DA90", VA = "0x187B6F090")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int DCENKJOPBFC = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NLLPLOLNIGD<float> ABDDOICEBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int MFNECJEFNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private float DCHIADENBND;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int FFDAEOBHFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F4C0", Offset = "0x7B6DEC0", VA = "0x187B6F4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float FIPIFGHOOPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F430", Offset = "0x7B6DE30", VA = "0x187B6F430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float BHOIICLOICO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F400", Offset = "0x7B6DE00", VA = "0x187B6F400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCE4BC0", Offset = "0xCE35C0", VA = "0x180CE4BC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool LHHKBKJDBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7B6F0B0", Offset = "0x7B6DAB0", VA = "0x187B6F0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F320", Offset = "0x7B6DD20", VA = "0x187B6F320")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F130", Offset = "0x7B6DB30", VA = "0x187B6F130")]
		private void OnAudioFilterRead(float[] HPGIDELCODH, int BMGCDDKKJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6F370", Offset = "0x7B6DD70", VA = "0x187B6F370")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IJHLHHNOODF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int ILCKJHDHLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, BECPOFPPNAB> LHKNAOLLNCL();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, BECPOFPPNAB> PMCGGLGAFJC();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, MFIDGNDLDCH)> CACBLGEHBHN();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MFIDGNDLDCH GIABNBMEHHO();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup FFLMDIMKBPE(MAKLNDOJCLN HLFGMKBGEKP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup MFGDBKJFKKO(MFIDGNDLDCH EMBHABJMOGB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource OGFNFOFHHAK(RecRoomAudioClip LMOCIJIEAIL, Transform MBNHCDHACDG, [Optional] AudioRolloff NIJCOLJNOPB, [Optional] Action<SFXAudioSource> OCLLJACPEIC, [Optional] MFIDGNDLDCH? HLFGMKBGEKP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMPKOOMCDME(SFXAudioSource APOIGODAPJI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource FKDJABKJECG(RecRoomAudioClip[] DFBIDOKJFFA, bool ODMDKANBKKL = false, float PBDIHGGIMAG = 1f, [Optional] Action<SFXAudioSource> OCLLJACPEIC, [Optional] MFIDGNDLDCH? HLFGMKBGEKP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource KBOPOKKHPCI(RecRoomAudioClip[] DFBIDOKJFFA, Transform MBNHCDHACDG, [Optional] AudioRolloff NIJCOLJNOPB, bool ODMDKANBKKL = false, [Optional] Action<SFXAudioSource> OCLLJACPEIC, [Optional] MFIDGNDLDCH? HLFGMKBGEKP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource JFLDPANAAGH(RecRoomAudioClip NPDEGLPNOAF, Vector3 CGIEBFAPHLM, [Optional] AudioRolloff NIJCOLJNOPB, [Optional] Action<SFXAudioSource> OCLLJACPEIC, [Optional] MFIDGNDLDCH? HLFGMKBGEKP, bool PBPLIEFLBJF = false, bool IEFEADHDEFL = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource LDPFAOFMAFB(RecRoomAudioClip PMDIKJALACN, [Optional] Action<SFXAudioSource> OCLLJACPEIC, [Optional] MFIDGNDLDCH? HLFGMKBGEKP, bool PBPLIEFLBJF = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDJIHHOMEIC OKDGBJOCOOD(SFXAudioSource APOIGODAPJI, float FOIKNBMKEKG, float IDDLOIFGNLI);
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
			[Cpp2IlInjected.Address(RVA = "0x7B70030", Offset = "0x7B6EA30", VA = "0x187B70030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7B70080", Offset = "0x7B6EA80", VA = "0x187B70080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FFE0", Offset = "0x7B6E9E0", VA = "0x187B6FFE0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FFF0", Offset = "0x7B6E9F0", VA = "0x187B6FFF0")]
		public RecRoomAudioClip(AudioClip PMDIKJALACN)
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B6FF20", Offset = "0x7B6E920", VA = "0x187B6FF20")]
		public bool EFLIOPGFGEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
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
		protected SFXTrack.OGFELPPKIHL trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B6ED90", Offset = "0x7B6D790", VA = "0x187B6ED90")]
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
		public SFXTrack.OGFELPPKIHL TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
			get
			{
				return default(SFXTrack.OGFELPPKIHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B6EAF0", Offset = "0x7B6D4F0", VA = "0x187B6EAF0")]
		protected void APILIJCHFDC(string AHDGJCPPJHB, SFXTrack.OGFELPPKIHL FOKEEAJFOBO, Guid FNKCCICOAII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6EC80", Offset = "0x7B6D680", VA = "0x187B6EC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6EBA0", Offset = "0x7B6D5A0", VA = "0x187B6EBA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6ECD0", Offset = "0x7B6D6D0", VA = "0x187B6ECD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BE80", Offset = "0xA5A880", VA = "0x180A5BE80", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B70110", Offset = "0x7B6EB10", VA = "0x187B70110")]
		public void APILIJCHFDC(string AHDGJCPPJHB, SFXTrack.OGFELPPKIHL FOKEEAJFOBO, Guid FNKCCICOAII, float OLKNKBMJEGI, AssetReference ECNADIOLHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B6ECD0", Offset = "0x7B6D6D0", VA = "0x187B6ECD0")]
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
		private sealed class MABLHHKNADP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public MABLHHKNADP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B6FDC0", Offset = "0x7B6E7C0", VA = "0x187B6FDC0")]
			internal FINLMOPIAGC<Guid>.LGNMDAGAPMG COGMJMPPPBC(RuntimeAddressableSFXTrack track)
			{
				return default(FINLMOPIAGC<Guid>.LGNMDAGAPMG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FINLMOPIAGC<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7B71FC0", Offset = "0x7B709C0", VA = "0x187B71FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FINLMOPIAGC<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7B71E30", Offset = "0x7B70830", VA = "0x187B71E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B71AC0", Offset = "0x7B704C0", VA = "0x187B71AC0")]
		public ODDHNIEMFCD<AudioClip> KPNPDEDJJMP(Guid MKJINKEDGFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B71A20", Offset = "0x7B70420", VA = "0x187B71A20")]
		private ODDHNIEMFCD<AudioClip> KPNPDEDJJMP(AssetReference FPINMIPHNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B71D90", Offset = "0x7B70790", VA = "0x187B71D90")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, OJHGNHGFLCL.CKAOICDAOMK
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct KKFMGNGDFDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float? KKPDMHMACCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float? DIGFMHNEHAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Vector3 NANOFNELMOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Transform HEOPLNJKOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AudioRolloff AOEEKHEKHLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public float KCNLIALJAFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float JBDIEOLJJFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public MAKLNDOJCLN? NHDLILEENLI;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public float MLAKHDLMGFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0x7B6FD40", Offset = "0x7B6E740", VA = "0x187B6FD40")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public MAKLNDOJCLN OBDIPPNFAHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x7B6FCF0", Offset = "0x7B6E6F0", VA = "0x187B6FCF0")]
				get
				{
					return default(MAKLNDOJCLN);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct IDAAKJGODAF : IAsyncStateMachine
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
			public KKFMGNGDFDO playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x7B6F550", Offset = "0x7B6DF50", VA = "0x187B6F550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7B6FB00", Offset = "0x7B6E500", VA = "0x187B6FB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IHCPKDAFBFF : IEnumerator<HGOIDBIKHMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private HGOIDBIKHMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private HGOIDBIKHMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public IHCPKDAFBFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6FC20", Offset = "0x7B6E620", VA = "0x187B6FC20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B6FCA0", Offset = "0x7B6E6A0", VA = "0x187B6FCA0", Slot = "8")]
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
		private Action<SFXAudioSource> KIKFCCOKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LIJLGGILNGM KMAOBOPLKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool KJJCFGELJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private JJPMOJNHOLC DCOMIILDBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IJHLHHNOODF KAMLLKDEBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool? NILELOJPODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private float OGCLNIILHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private float IJAAEJLLHHE;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string BOJCDJFHMAL = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HEOPLNJKOPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool GEBLDJICNID
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7B709E0", Offset = "0x7B6F3E0", VA = "0x187B709E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BIBJPNFJFHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7B71900", Offset = "0x7B70300", VA = "0x187B71900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MFHJOBCOGKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7B719E0", Offset = "0x7B703E0", VA = "0x187B719E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool PICAJKCCMKL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7B719C0", Offset = "0x7B703C0", VA = "0x187B719C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KKPDMHMACCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7B71A00", Offset = "0x7B70400", VA = "0x187B71A00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float EKOFCFLLNFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7B71920", Offset = "0x7B70320", VA = "0x187B71920")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B708F0", Offset = "0x7B6F2F0", VA = "0x187B708F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B70B30", Offset = "0x7B6F530", VA = "0x187B70B30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B71820", Offset = "0x7B70220", VA = "0x187B71820")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B71800", Offset = "0x7B70200", VA = "0x187B71800")]
		public void UpdateVolume(float OFLAAKHNMFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B71600", Offset = "0x7B70000", VA = "0x187B71600")]
		public void UpdatePitch(float FLDKCFIBGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B71560", Offset = "0x7B6FF60", VA = "0x187B71560")]
		public void UpdateDopplerLevel(float NMBALANEFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B71760", Offset = "0x7B70160", VA = "0x187B71760")]
		public void UpdateSpatialBlend(float KIPGNMMBFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7B71490", Offset = "0x7B6FE90", VA = "0x187B71490")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B70E10", Offset = "0x7B6F810", VA = "0x187B70E10")]
		public void Play(AudioClip PMDIKJALACN, float OFLAAKHNMFA, Vector3 CGIEBFAPHLM, float ELOKAKGHBLH, float OCCCABKPCPA, AudioRolloff JDKACBOPDBE, [Optional] Action<SFXAudioSource> DLOOOIOLFPA, [Optional] MFIDGNDLDCH? HLFGMKBGEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B70CC0", Offset = "0x7B6F6C0", VA = "0x187B70CC0")]
		[AsyncStateMachine(typeof(IDAAKJGODAF))]
		public Task PlayAsync(AudioClip PMDIKJALACN, KKFMGNGDFDO FAMGHHGKDEE, CancellationToken JKPNCAGHEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B701E0", Offset = "0x7B6EBE0", VA = "0x187B701E0")]
		private void ACLKEGDBOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B70AE0", Offset = "0x7B6F4E0", VA = "0x187B70AE0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B714C0", Offset = "0x7B6FEC0", VA = "0x187B714C0")]
		public void Scrub(float FDFNAMJJMBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B71520", Offset = "0x7B6FF20", VA = "0x187B71520")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B713B0", Offset = "0x7B6FDB0", VA = "0x187B713B0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B71330", Offset = "0x7B6FD30", VA = "0x187B71330")]
		[IteratorStateMachine(typeof(IHCPKDAFBFF))]
		public IEnumerator<HGOIDBIKHMF> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B70AD0", Offset = "0x7B6F4D0", VA = "0x187B70AD0", Slot = "4")]
		private void GLLGLKKGEHL(bool JJAMIIBHPKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
