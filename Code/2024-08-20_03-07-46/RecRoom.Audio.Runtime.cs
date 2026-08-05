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
public static class IHANKOIILFO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67FD1A0", Offset = "0x67FC1A0", VA = "0x1867FD1A0")]
	public static void JGNMNJNAHEB(this AudioSource LANFPDCMIFG, AudioRolloff CMPJGGFPPNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FKOCJJIGCCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FCB20", Offset = "0x67FBB20", VA = "0x1867FCB20")]
	public static float EJNCOPMMOGI(float JFKDEAIOKHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67FCAE0", Offset = "0x67FBAE0", VA = "0x1867FCAE0")]
	public static float COADLCNPDDP(float MJBOJHONOOI)
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
		[Cpp2IlInjected.Address(RVA = "0x67FC730", Offset = "0x67FB730", VA = "0x1867FC730")]
		public float MPGPLAFDJLF(float AFLFICBEHKF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67FC9F0", Offset = "0x67FB9F0", VA = "0x1867FC9F0")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LKMAAFPKFEK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int FOOOKDLFFKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, KDGMAMLGGIL> DEGLBFDHNKP();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, PBGIIEBLILN)> CBDPPOEMEMG();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup JGDCHBOFHDL(DAIEANLCDAC KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup IFLEPGHDDMI(PBGIIEBLILN FNDOGKMIMGF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource EBMELBEJDOF(RecRoomAudioClip PBFNAAKDOLC, Transform KDCMCOGKGOE, [Optional] AudioRolloff IDHHIOBAGGC, [Optional] Action<SFXAudioSource> FKEHMAJPGMG, [Optional] PBGIIEBLILN? KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GICONAIDNIF(SFXAudioSource CNNBJAEEHID);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource CNCEFHMFKMO(RecRoomAudioClip[] PJPIACFLMGL, bool FIGCOHPOEAL = false, float JCMELBCFHLN = 1f, [Optional] Action<SFXAudioSource> FKEHMAJPGMG, [Optional] PBGIIEBLILN? KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource IFNKDCIGKAD(RecRoomAudioClip[] PJPIACFLMGL, Transform KDCMCOGKGOE, [Optional] AudioRolloff IDHHIOBAGGC, bool FIGCOHPOEAL = false, [Optional] Action<SFXAudioSource> FKEHMAJPGMG, [Optional] PBGIIEBLILN? KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource CBPLLBENNMJ(RecRoomAudioClip MJOIOGPLJFP, Vector3 GMKCAOILOEC, bool EGOOKFKEPFK, [Optional] AudioRolloff IDHHIOBAGGC, [Optional] Action<SFXAudioSource> FKEHMAJPGMG, [Optional] PBGIIEBLILN? KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource IBDNHNPFELB(RecRoomAudioClip NOGOAIHHABO, [Optional] Action<SFXAudioSource> FKEHMAJPGMG, [Optional] PBGIIEBLILN? KCGMPLKNLCG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HDBNHMIPDLF PHCMIALABFL(SFXAudioSource CNNBJAEEHID, float EGJKECAHOKL, float OCJBGOIAOCN);
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
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67FD450", Offset = "0x67FC450", VA = "0x1867FD450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67FD4A0", Offset = "0x67FC4A0", VA = "0x1867FD4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67FD400", Offset = "0x67FC400", VA = "0x1867FD400")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67FD410", Offset = "0x67FC410", VA = "0x1867FD410")]
		public RecRoomAudioClip(AudioClip NOGOAIHHABO)
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
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67FD330", Offset = "0x67FC330", VA = "0x1867FD330")]
		public bool KDCKMGKCBKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x939730", Offset = "0x938730", VA = "0x180939730")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SFXAudioSource : MonoBehaviour, IGLOFLIELDK.FPHDGAKKLNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct KOKACHNLHJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float? FAKIFMINMEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float? KODPNEGBINJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Vector3 PNFAKDKJDLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform KJHLGONFMHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AudioRolloff OJHIECOJEEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float MNKOLLINDBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float GHDFAEFJPPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public DAIEANLCDAC? PCGIKDPNFFA;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float AIPOPDGPALP
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x67FD260", Offset = "0x67FC260", VA = "0x1867FD260")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public DAIEANLCDAC PMKHFMDOOKJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x67FD2E0", Offset = "0x67FC2E0", VA = "0x1867FD2E0")]
				get
				{
					return default(DAIEANLCDAC);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct IAGFCBEPEPL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public KOKACHNLHJN playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67FCB80", Offset = "0x67FBB80", VA = "0x1867FCB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x67FD140", Offset = "0x67FC140", VA = "0x1867FD140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CICIPKGLDOG : IEnumerator<FAKEPIEMOLB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private FAKEPIEMOLB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private FAKEPIEMOLB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x857C10", Offset = "0x856C10", VA = "0x180857C10")]
			[DebuggerHidden]
			public CICIPKGLDOG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x67FCA10", Offset = "0x67FBA10", VA = "0x1867FCA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x67FCA90", Offset = "0x67FBA90", VA = "0x1867FCA90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Action<SFXAudioSource> OJNLLKGGJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AKGDPKBFKBL FIJGBGCNNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GFDNMDGANLI GDBAFIANBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LKMAAFPKFEK NKMOEIJJPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float ECGNJCPBHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float CCKIFFFMINC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string GJMGNFNNBMA = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform KJHLGONFMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int FHELNFEJIFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67FEAF0", Offset = "0x67FDAF0", VA = "0x1867FEAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IDBLJICCIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67FEBD0", Offset = "0x67FDBD0", VA = "0x1867FEBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool MLIOJKEIANB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x67FEBB0", Offset = "0x67FDBB0", VA = "0x1867FEBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float FAKIFMINMEL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67FEBF0", Offset = "0x67FDBF0", VA = "0x1867FEBF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float OGLNCBBJLOG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x67FEB10", Offset = "0x67FDB10", VA = "0x1867FEB10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67FD530", Offset = "0x67FC530", VA = "0x1867FD530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67FDD60", Offset = "0x67FCD60", VA = "0x1867FDD60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67FEA30", Offset = "0x67FDA30", VA = "0x1867FEA30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67FEA10", Offset = "0x67FDA10", VA = "0x1867FEA10")]
		public void UpdateVolume(float HPDNOEFJLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67FE800", Offset = "0x67FD800", VA = "0x1867FE800")]
		public void UpdatePitch(float JADFHIHBHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67FE760", Offset = "0x67FD760", VA = "0x1867FE760")]
		public void UpdateDopplerLevel(float PCAPMFNPBHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67FE970", Offset = "0x67FD970", VA = "0x1867FE970")]
		public void UpdateSpatialBlend(float OHBHMFBHMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67FE690", Offset = "0x67FD690", VA = "0x1867FE690")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67FE050", Offset = "0x67FD050", VA = "0x1867FE050")]
		public void Play(AudioClip NOGOAIHHABO, float HPDNOEFJLND, Vector3 GMKCAOILOEC, float CIFBJKLAPOB, float CHFCCPKPNHF, AudioRolloff CMPJGGFPPNM, [Optional] Action<SFXAudioSource> FCJDMILFFHM, [Optional] PBGIIEBLILN? KCGMPLKNLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67FDF00", Offset = "0x67FCF00", VA = "0x1867FDF00")]
		[AsyncStateMachine(typeof(IAGFCBEPEPL))]
		public Task PlayAsync(AudioClip NOGOAIHHABO, KOKACHNLHJN CKJKHBELHHA, CancellationToken LABHBAHABKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67FD650", Offset = "0x67FC650", VA = "0x1867FD650")]
		private void NBHMFNOPLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67FD600", Offset = "0x67FC600", VA = "0x1867FD600")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67FE6C0", Offset = "0x67FD6C0", VA = "0x1867FE6C0")]
		public void Scrub(float PJONDALPKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67FE720", Offset = "0x67FD720", VA = "0x1867FE720")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67FE5C0", Offset = "0x67FD5C0", VA = "0x1867FE5C0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67FE540", Offset = "0x67FD540", VA = "0x1867FE540")]
		[IteratorStateMachine(typeof(CICIPKGLDOG))]
		public IEnumerator<FAKEPIEMOLB> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67FDEF0", Offset = "0x67FCEF0", VA = "0x1867FDEF0", Slot = "4")]
		private void PMAIJNJNBHC(bool HHLLKDECJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
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
