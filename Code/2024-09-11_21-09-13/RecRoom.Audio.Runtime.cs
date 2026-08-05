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
public static class CNADMNGHLML
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69EC160", Offset = "0x69EA760", VA = "0x1869EC160")]
	public static void EEPHAAALNIO(this AudioSource BEAIEDGOHFO, AudioRolloff HFKLCEKBNEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OBGAKCOAEEI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69ECA10", Offset = "0x69EB010", VA = "0x1869ECA10")]
	public static float KLAKGOLPJEI(float AMNHMEGFGOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69EC9D0", Offset = "0x69EAFD0", VA = "0x1869EC9D0")]
	public static float IJNJGOLAOFD(float PJIMOIFMLDL)
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
		[Cpp2IlInjected.Address(RVA = "0x69EBE80", Offset = "0x69EA480", VA = "0x1869EBE80")]
		public float LJDELOMMMDM(float GEMJFNNHCFJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69EC140", Offset = "0x69EA740", VA = "0x1869EC140")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ODMMCDNNHNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int ANMBNCJPHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, OKCGCELKKAL> FLOLKOENPKN();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, MPEJPGOFLJD)> JOBADKFNDEA();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup JGNMJOMNHAM(IFDACHFFLOD CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup JOIACGAODPA(MPEJPGOFLJD ILDBFFCKFBD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource MPIHLPDGFCN(RecRoomAudioClip MHDAOLNHNFJ, Transform OGGGOKFFAKH, [Optional] AudioRolloff PEAEIIAFOEA, [Optional] Action<SFXAudioSource> AFPMMEGGNEK, [Optional] MPEJPGOFLJD? CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHJCELGOPGL(SFXAudioSource FMHHFPIAGFL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource IOLPCGLKDGM(RecRoomAudioClip[] DBJKJDAINHN, bool INDBOGKEAJJ = false, float CPNGDDLIGCE = 1f, [Optional] Action<SFXAudioSource> AFPMMEGGNEK, [Optional] MPEJPGOFLJD? CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource LALBPPBEAMF(RecRoomAudioClip[] DBJKJDAINHN, Transform OGGGOKFFAKH, [Optional] AudioRolloff PEAEIIAFOEA, bool INDBOGKEAJJ = false, [Optional] Action<SFXAudioSource> AFPMMEGGNEK, [Optional] MPEJPGOFLJD? CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource MNFLEFHEBAI(RecRoomAudioClip JLJGCLMAKJK, Vector3 IFDMLAIJAHF, bool DFGMONMJJNE, [Optional] AudioRolloff PEAEIIAFOEA, [Optional] Action<SFXAudioSource> AFPMMEGGNEK, [Optional] MPEJPGOFLJD? CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource HFOLFNBDMDI(RecRoomAudioClip LHOOIDNBDAG, [Optional] Action<SFXAudioSource> AFPMMEGGNEK, [Optional] MPEJPGOFLJD? CLBPLOJAIGD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EPGCCCKMEBG PCKKHFMOCAH(SFXAudioSource FMHHFPIAGFL, float OCAOCAPODEC, float MCPPIEMELEJ);
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
			[Cpp2IlInjected.Address(RVA = "0x69ECB90", Offset = "0x69EB190", VA = "0x1869ECB90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69ECBE0", Offset = "0x69EB1E0", VA = "0x1869ECBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69ECB40", Offset = "0x69EB140", VA = "0x1869ECB40")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69ECB50", Offset = "0x69EB150", VA = "0x1869ECB50")]
		public RecRoomAudioClip(AudioClip LHOOIDNBDAG)
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69ECA70", Offset = "0x69EB070", VA = "0x1869ECA70")]
		public bool AJJNJNNLKDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x903180", Offset = "0x901780", VA = "0x180903180")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SFXAudioSource : MonoBehaviour, EFAKGCHJGJK.BAMPAHANABO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct GHKIGFACNHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float? MMHNIAMMFJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float? CDKOONABJMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Vector3 GLEHEIPFKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform MNJDAMLEGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AudioRolloff NJDLBDBKPDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float JMLFJDFLKCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float HDBINCHNLBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public IFDACHFFLOD? KINHMCKMMKG;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float GNHKKCMIDLM
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x69EC2F0", Offset = "0x69EA8F0", VA = "0x1869EC2F0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public IFDACHFFLOD OECDILKIMJK
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x69EC370", Offset = "0x69EA970", VA = "0x1869EC370")]
				get
				{
					return default(IFDACHFFLOD);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct JBJMGCHHBDD : IAsyncStateMachine
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
			public GHKIGFACNHN playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x69EC3C0", Offset = "0x69EA9C0", VA = "0x1869EC3C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69EC970", Offset = "0x69EAF70", VA = "0x1869EC970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CPDFNDOBOEI : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public CPDFNDOBOEI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x69EC220", Offset = "0x69EA820", VA = "0x1869EC220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x69EC2A0", Offset = "0x69EA8A0", VA = "0x1869EC2A0", Slot = "8")]
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
		private Action<SFXAudioSource> APMHKJKAMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IBILKJCONGN AMEFIPHMJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private LEBBOCDPOJL CBFLBANKJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ODMMCDNNHNA LLCFDOENKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float HIFEIFHPNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float HOODGDLGLFM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string JEPBOHDLMPI = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform MNJDAMLEGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BDDHIOEBCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x69EE230", Offset = "0x69EC830", VA = "0x1869EE230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IKAACABFNFF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69EE310", Offset = "0x69EC910", VA = "0x1869EE310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NIAHOPIPDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69EE2F0", Offset = "0x69EC8F0", VA = "0x1869EE2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MMHNIAMMFJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x69EE330", Offset = "0x69EC930", VA = "0x1869EE330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MPKDAOKCADM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x69EE250", Offset = "0x69EC850", VA = "0x1869EE250")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69ECC70", Offset = "0x69EB270", VA = "0x1869ECC70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69ED4C0", Offset = "0x69EBAC0", VA = "0x1869ED4C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69EE170", Offset = "0x69EC770", VA = "0x1869EE170")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69EE150", Offset = "0x69EC750", VA = "0x1869EE150")]
		public void UpdateVolume(float GMBAJBFBJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69EDF50", Offset = "0x69EC550", VA = "0x1869EDF50")]
		public void UpdatePitch(float DNOIKHKLKNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69EDEB0", Offset = "0x69EC4B0", VA = "0x1869EDEB0")]
		public void UpdateDopplerLevel(float IHIPBOEALCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69EE0B0", Offset = "0x69EC6B0", VA = "0x1869EE0B0")]
		public void UpdateSpatialBlend(float JLIGOINHPFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69EDDE0", Offset = "0x69EC3E0", VA = "0x1869EDDE0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69ED7A0", Offset = "0x69EBDA0", VA = "0x1869ED7A0")]
		public void Play(AudioClip LHOOIDNBDAG, float GMBAJBFBJBB, Vector3 IFDMLAIJAHF, float FPLAIPJAFKM, float JLLGMALPLGM, AudioRolloff HFKLCEKBNEN, [Optional] Action<SFXAudioSource> IMNEIJNIEGC, [Optional] MPEJPGOFLJD? CLBPLOJAIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69ED650", Offset = "0x69EBC50", VA = "0x1869ED650")]
		[AsyncStateMachine(typeof(JBJMGCHHBDD))]
		public Task PlayAsync(AudioClip LHOOIDNBDAG, GHKIGFACNHN FHNNGLGBCHE, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69ECDC0", Offset = "0x69EB3C0", VA = "0x1869ECDC0")]
		private void MEAELBJNFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69ECD70", Offset = "0x69EB370", VA = "0x1869ECD70")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69EDE10", Offset = "0x69EC410", VA = "0x1869EDE10")]
		public void Scrub(float IMAGIDBPDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69EDE70", Offset = "0x69EC470", VA = "0x1869EDE70")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69EDD10", Offset = "0x69EC310", VA = "0x1869EDD10")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69EDC90", Offset = "0x69EC290", VA = "0x1869EDC90")]
		[IteratorStateMachine(typeof(CPDFNDOBOEI))]
		public IEnumerator<GJDHNIMFMOA> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69ECD60", Offset = "0x69EB360", VA = "0x1869ECD60", Slot = "4")]
		private void KGKLGNPDBNA(bool OPPPLDKFPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
