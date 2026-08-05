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
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AJICGIHFLEK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AJBBLAKNCNM
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum OAAFLKIAFBB
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	CoachVO
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IJFGELIDAGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly OAAFLKIAFBB FHKGMAGNOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string GHCCBFCCFDE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66EA2D0", Offset = "0x66E8AD0", VA = "0x1866EA2D0")]
	public IJFGELIDAGN(OAAFLKIAFBB CIDLDHDAJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66EA260", Offset = "0x66E8A60", VA = "0x1866EA260")]
	public IJFGELIDAGN(OAAFLKIAFBB CIDLDHDAJHK, string LBGOHBINJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66EA1D0", Offset = "0x66E89D0", VA = "0x1866EA1D0")]
	public bool EFMJEOLKLKK(OAAFLKIAFBB EJOGKFCFHKL, string OJAOFBJHOBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KEBIKHKIEKA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GCLECGHHELH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66E9A30", Offset = "0x66E8230", VA = "0x1866E9A30")]
	public static void DAEEOMAEFLE(this AudioSource PKFJDJMNAEL, AudioRolloff BAABFBBOJNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LKMLOLJOPMC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66EA360", Offset = "0x66E8B60", VA = "0x1866EA360")]
	public static float AKMEGFPDFNF(float KJCIJGAPKJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66EA3C0", Offset = "0x66E8BC0", VA = "0x1866EA3C0")]
	public static float CABKIAKMCHG(float GAPDJGFIJDG)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66E9680", Offset = "0x66E7E80", VA = "0x1866E9680")]
		public float HIAOOBJIMBA(float DABDJLLOPKD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66E9940", Offset = "0x66E8140", VA = "0x1866E9940")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HILNIMOLCKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JPJIBPOINNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, FOFCIDGPHKD> HMDANPJPPMO();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, IJFGELIDAGN)> LMKDEOMEJFK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup EMMFGHCJNOM(OAAFLKIAFBB CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup IELIDEFCOKE(IJFGELIDAGN PDCLEIEMCIF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource CMBGGBECGED(RecRoomAudioClip OKKPJJCPFED, Transform BDLAOEKFJGA, [Optional] AudioRolloff IHPNJONECIP, [Optional] Action<SFXAudioSource> HGPPOBHJCLM, [Optional] IJFGELIDAGN? CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NPCGNJHFGAP(SFXAudioSource IABJOCPOMEI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource MHIPEMJDOHI(RecRoomAudioClip[] PCMKNDLKFME, bool CFJFAOOGMCE = false, float IHLBCHLLGGN = 1f, [Optional] Action<SFXAudioSource> HGPPOBHJCLM, [Optional] IJFGELIDAGN? CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource JGIBPKMONNA(RecRoomAudioClip[] PCMKNDLKFME, Transform BDLAOEKFJGA, [Optional] AudioRolloff IHPNJONECIP, bool CFJFAOOGMCE = false, [Optional] Action<SFXAudioSource> HGPPOBHJCLM, [Optional] IJFGELIDAGN? CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource IGPBMBIODMN(RecRoomAudioClip OHLIPLNMCKH, Vector3 BGLKCAHKMON, bool EOKPGPJDPEL, [Optional] AudioRolloff IHPNJONECIP, [Optional] Action<SFXAudioSource> HGPPOBHJCLM, [Optional] IJFGELIDAGN? CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource ENCCCINJKBF(RecRoomAudioClip AJFGHGEACLD, [Optional] Action<SFXAudioSource> HGPPOBHJCLM, [Optional] IJFGELIDAGN? CIDLDHDAJHK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JLAFAKOGFMB DPIGGNEMMGP(SFXAudioSource IABJOCPOMEI, float GBLHDACHDOL, float EKBDOJGAIJB);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x66EA520", Offset = "0x66E8D20", VA = "0x1866EA520")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x66EA570", Offset = "0x66E8D70", VA = "0x1866EA570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66EA4D0", Offset = "0x66E8CD0", VA = "0x1866EA4D0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x66EA4E0", Offset = "0x66E8CE0", VA = "0x1866EA4E0")]
		public RecRoomAudioClip(AudioClip AJFGHGEACLD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66EA400", Offset = "0x66E8C00", VA = "0x1866EA400")]
		public bool MGABDMMLBKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, DJDMDILEMEG.GJJPHBPFAGP
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct HCNBEHBLJLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? GJJNOFAOIIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float? KLEHGIBPDOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Vector3 DBBAIAABOHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Transform OFJNACNOHJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AudioRolloff KHBOCBIDAIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float DEPKFGGEIGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float BKODFNFDLKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public OAAFLKIAFBB? FHKGMAGNOCN;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float JBPJLANFEJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x66E9AF0", Offset = "0x66E82F0", VA = "0x1866E9AF0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public OAAFLKIAFBB LAGHOGEKOJO
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x66E9B70", Offset = "0x66E8370", VA = "0x1866E9B70")]
				get
				{
					return default(OAAFLKIAFBB);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct HNHGGALCHKI : IAsyncStateMachine
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
			public HCNBEHBLJLB playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66E9BC0", Offset = "0x66E83C0", VA = "0x1866E9BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x66EA170", Offset = "0x66E8970", VA = "0x1866EA170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DBPLMALBJOP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public DBPLMALBJOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x66E9960", Offset = "0x66E8160", VA = "0x1866E9960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x66E99E0", Offset = "0x66E81E0", VA = "0x1866E99E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Action<SFXAudioSource> ONFFOOCPINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private PEJDBLFKJJN JBNKGIENHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LKKABOLKPGL MHHDJENGBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HILNIMOLCKN AIEOGNKMOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float INFIDMPHIKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float PCMCPMOEFKH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string HHIMGMNGFIK = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform OFJNACNOHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int CELOLMGEEMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x66EBBA0", Offset = "0x66EA3A0", VA = "0x1866EBBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ALADHDIDOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x66EBC80", Offset = "0x66EA480", VA = "0x1866EBC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NJFIJOBJJFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66EBC60", Offset = "0x66EA460", VA = "0x1866EBC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float GJJNOFAOIIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x66EBCA0", Offset = "0x66EA4A0", VA = "0x1866EBCA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float CBACHMILAOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66EBBC0", Offset = "0x66EA3C0", VA = "0x1866EBBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66EA600", Offset = "0x66E8E00", VA = "0x1866EA600")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66EAE30", Offset = "0x66E9630", VA = "0x1866EAE30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x66EBAE0", Offset = "0x66EA2E0", VA = "0x1866EBAE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x66EBAC0", Offset = "0x66EA2C0", VA = "0x1866EBAC0")]
		public void UpdateVolume(float NANGAMIJPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66EB8C0", Offset = "0x66EA0C0", VA = "0x1866EB8C0")]
		public void UpdatePitch(float BPNKLIDACAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x66EB820", Offset = "0x66EA020", VA = "0x1866EB820")]
		public void UpdateDopplerLevel(float CBOKHCPFINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66EBA20", Offset = "0x66EA220", VA = "0x1866EBA20")]
		public void UpdateSpatialBlend(float AIDDJJOMOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x66EB750", Offset = "0x66E9F50", VA = "0x1866EB750")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB110", Offset = "0x66E9910", VA = "0x1866EB110")]
		public void Play(AudioClip AJFGHGEACLD, float NANGAMIJPBE, Vector3 BGLKCAHKMON, float FILDGHLLAOO, float ABCFOHFGKGF, AudioRolloff BAABFBBOJNM, [Optional] Action<SFXAudioSource> CODOLDFFBNP, [Optional] IJFGELIDAGN? CIDLDHDAJHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x66EAFC0", Offset = "0x66E97C0", VA = "0x1866EAFC0")]
		[AsyncStateMachine(typeof(HNHGGALCHKI))]
		public Task PlayAsync(AudioClip AJFGHGEACLD, HCNBEHBLJLB NDAEALEOLIC, CancellationToken ODNHMAMKFFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x66EA6D0", Offset = "0x66E8ED0", VA = "0x1866EA6D0")]
		private void FKDCOIBEAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x66EADE0", Offset = "0x66E95E0", VA = "0x1866EADE0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x66EB780", Offset = "0x66E9F80", VA = "0x1866EB780")]
		public void Scrub(float KJAPNCDOIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x66EB7E0", Offset = "0x66E9FE0", VA = "0x1866EB7E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66EB680", Offset = "0x66E9E80", VA = "0x1866EB680")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66EB600", Offset = "0x66E9E00", VA = "0x1866EB600")]
		[IteratorStateMachine(typeof(DBPLMALBJOP))]
		public IEnumerator<PENLHNEFADH> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x66EADD0", Offset = "0x66E95D0", VA = "0x1866EADD0", Slot = "4")]
		private void HMBPHLLPPMI(bool GBHPPBEDPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
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
