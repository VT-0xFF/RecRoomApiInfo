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
public enum PGAABLFJDBL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum APKHPFIIDIM
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
public enum ENPEHNDFNDD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CNNDBAEFGNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly ENPEHNDFNDD IFNHCFOBKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string NBCFADOIFKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7238640", Offset = "0x7237640", VA = "0x187238640")]
	public CNNDBAEFGNN(ENPEHNDFNDD KNINKPKCGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72386E0", Offset = "0x72376E0", VA = "0x1872386E0")]
	public CNNDBAEFGNN(ENPEHNDFNDD KNINKPKCGGL, string NCBAAMJMEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72385B0", Offset = "0x72375B0", VA = "0x1872385B0")]
	public bool PBEKGAABLII(ENPEHNDFNDD EEDHEPCEJBG, string HCBBDJEDNIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LJIFAJPPDCB
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ODKLJGPNBNH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const int OJNHPBAOIAB = 0;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const int NIAIENIHMPI = 2;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int HMAJMGOCLBE = 2;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public ODKLJGPNBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EMBGBMCGBNC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NOCBLNOFJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, GOOEBCPCLOE> OKGDNHLAHLN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, CNNDBAEFGNN)> JCEAABLHIDK();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup BCOOLMFAMPP(ENPEHNDFNDD KNINKPKCGGL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup DDCAIIBPBKD(CNNDBAEFGNN APNAKHKCHEF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDHMIMLJGFP(AudioSource ECGLLFMOHBH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource EPAKAFOECBK(RecRoomAudioClip GGOOCMPGPDO, Transform EICHJEHGNLG, [Optional] AudioRolloff PDKKLIHKGFH, [Optional] Action<SFXAudioSource> IOPPPGPKAGE, [Optional] CNNDBAEFGNN? KNINKPKCGGL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNHAOPAOCCM(SFXAudioSource ECGLLFMOHBH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource FFCBIJBNJMO(RecRoomAudioClip[] NJJFMNDEDJB, bool HJBNCNKHJJO = false, float OILNGBPANBE = 1f, [Optional] Action<SFXAudioSource> IOPPPGPKAGE, [Optional] CNNDBAEFGNN? KNINKPKCGGL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource EDFEFIJHLHK(RecRoomAudioClip[] NJJFMNDEDJB, Transform EICHJEHGNLG, [Optional] AudioRolloff PDKKLIHKGFH, bool HJBNCNKHJJO = false, [Optional] Action<SFXAudioSource> IOPPPGPKAGE, [Optional] CNNDBAEFGNN? KNINKPKCGGL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource HLDIADNOCKF(RecRoomAudioClip FAAAJNKEBBB, Vector3 GDBJDNPJJPO, bool NGIAPNDDGDE, [Optional] AudioRolloff PDKKLIHKGFH, [Optional] Action<SFXAudioSource> IOPPPGPKAGE, [Optional] CNNDBAEFGNN? KNINKPKCGGL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource CLEPGNCMDOE(RecRoomAudioClip HBPGIMDJINH, [Optional] Action<SFXAudioSource> IOPPPGPKAGE, [Optional] CNNDBAEFGNN? KNINKPKCGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LFNPCDBAEEI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const float GGEKOKLGJKG = -80f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const float JHLPAGNPCPH = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72389F0", Offset = "0x72379F0", VA = "0x1872389F0")]
	public static float GIEHAEHKCPP(float MGHDBLNFECI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x72389C0", Offset = "0x72379C0", VA = "0x1872389C0")]
	public static float CKHGPOKKBFG(float GOCNJLIGJJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public LFNPCDBAEEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HPLGOKPLHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7238830", Offset = "0x7237830", VA = "0x187238830")]
	public static void JDHMIMLJGFP(this AudioSource LANLMCCFABP, AudioRolloff GLLHLBAEHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x72388F0", Offset = "0x72378F0", VA = "0x1872388F0")]
	public static void LINBFBADNDI(this AudioSource ECGLLFMOHBH, RecRoomAudioClip OMFDAGGJNMO)
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72382F0", Offset = "0x72372F0", VA = "0x1872382F0")]
		public float DPCOLPNGOHJ(float KOCGFDLBEIL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7238590", Offset = "0x7237590", VA = "0x187238590")]
		public AudioRolloff()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7238D50", Offset = "0x7237D50", VA = "0x187238D50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7238DE0", Offset = "0x7237DE0", VA = "0x187238DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7238CF0", Offset = "0x7237CF0", VA = "0x187238CF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7238D90", Offset = "0x7237D90", VA = "0x187238D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7238C80", Offset = "0x7237C80", VA = "0x187238C80")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7238CA0", Offset = "0x7237CA0", VA = "0x187238CA0")]
		public RecRoomAudioClip(AudioClip HBPGIMDJINH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7238B10", Offset = "0x7237B10", VA = "0x187238B10")]
		public bool AFLCAJJIPHF(RecRoomAudioClip JONIFABKCAI)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7238A40", Offset = "0x7237A40", VA = "0x187238A40")]
		public bool FAFPICPNKMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, BOOFJICDMLJ.BFMILMHKMMO
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct FALNPAIPPJN
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private const float DDEJKIOLIPO = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private const float ELLEDMKLFGE = 1f;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private const ENPEHNDFNDD OCMNJPBPMHO = ENPEHNDFNDD.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float? LIEGGMOOKGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public float? COIPLLCLHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Vector3 AELLMJHJAPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Transform BCMAHIFJNND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioRolloff PFLADMBIKLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public float CJNMBHPAPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public float DEIJOKFGLMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ENPEHNDFNDD? IFNHCFOBKBF;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float KLBJDLMKMOK
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x7238750", Offset = "0x7237750", VA = "0x187238750")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public ENPEHNDFNDD LJAAIKLADLN
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x72387E0", Offset = "0x72377E0", VA = "0x1872387E0")]
				get
				{
					return default(ENPEHNDFNDD);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AJCJGJNBIIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public FALNPAIPPJN playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private float <pitch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public AJCJGJNBIIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7237CC0", Offset = "0x7236CC0", VA = "0x187237CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ABKLDNGIBOB : IEnumerator<KNGCLBDEHMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private KNGCLBDEHMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private KNGCLBDEHMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB1F9D0", Offset = "0xB1E9D0", VA = "0x180B1F9D0")]
			[DebuggerHidden]
			public ABKLDNGIBOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7237BD0", Offset = "0x7236BD0", VA = "0x187237BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7237C80", Offset = "0x7236C80", VA = "0x187237C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Action<SFXAudioSource> FEPHAGMIPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private BFCCHDPGONK PFKHJCFDAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[LHIKCFDKPCO(FEMKOOHMMFH.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private APHOMGELIDO HAOAKNADLPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private EMBGBMCGBNC IKKCAJJGFOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float AGLEMABKFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float NJPBIDBPLJE;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string NFILMAMNEEC = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform BCMAHIFJNND
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int INLJFIBPBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x723A510", Offset = "0x7239510", VA = "0x18723A510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CGDMLMPCGJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x723A600", Offset = "0x7239600", VA = "0x18723A600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JBMDJPOLBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x723A5E0", Offset = "0x72395E0", VA = "0x18723A5E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float LIEGGMOOKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x723A620", Offset = "0x7239620", VA = "0x18723A620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float PBAGBNNBFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x723A530", Offset = "0x7239530", VA = "0x18723A530")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7238E60", Offset = "0x7237E60", VA = "0x187238E60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7239720", Offset = "0x7238720", VA = "0x187239720")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x723A3E0", Offset = "0x72393E0", VA = "0x18723A3E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x723A3C0", Offset = "0x72393C0", VA = "0x18723A3C0")]
		public void UpdateVolume(float FDGGNHODCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x723A1A0", Offset = "0x72391A0", VA = "0x18723A1A0")]
		public void UpdatePitch(float BHMGCFCCHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x723A100", Offset = "0x7239100", VA = "0x18723A100")]
		public void UpdateDopplerLevel(float ICDGNNNIIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x723A320", Offset = "0x7239320", VA = "0x18723A320")]
		public void UpdateSpatialBlend(float IOKCIHDMCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x723A020", Offset = "0x7239020", VA = "0x18723A020")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7239A70", Offset = "0x7238A70", VA = "0x187239A70")]
		public void Play(AudioClip HBPGIMDJINH, float FDGGNHODCHI, Vector3 GDBJDNPJJPO, float DBKGHEIPEFF, float IGPLOCLKOME, AudioRolloff GLLHLBAEHOC, [Optional] Action<SFXAudioSource> OOPAEMLBFMP, [Optional] CNNDBAEFGNN? KNINKPKCGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72398B0", Offset = "0x72388B0", VA = "0x1872398B0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AJCJGJNBIIG))]
		public Task PlayAsync(AudioClip HBPGIMDJINH, FALNPAIPPJN ONCJAOIIAPF, CancellationToken AOAEIGNDKPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7238F30", Offset = "0x7237F30", VA = "0x187238F30")]
		private void LPLBDNKMLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72396D0", Offset = "0x72386D0", VA = "0x1872396D0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x723A050", Offset = "0x7239050", VA = "0x18723A050")]
		public void Scrub(float CPDGKFHMGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x723A0C0", Offset = "0x72390C0", VA = "0x18723A0C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7239F30", Offset = "0x7238F30", VA = "0x187239F30")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7239EC0", Offset = "0x7238EC0", VA = "0x187239EC0")]
		[IteratorStateMachine(typeof(ABKLDNGIBOB))]
		public IEnumerator<KNGCLBDEHMD> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7238F20", Offset = "0x7237F20", VA = "0x187238F20", Slot = "4")]
		private void BEGLMFGJFOL(bool LEOEHJANNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x723A4B0", Offset = "0x72394B0", VA = "0x18723A4B0")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
