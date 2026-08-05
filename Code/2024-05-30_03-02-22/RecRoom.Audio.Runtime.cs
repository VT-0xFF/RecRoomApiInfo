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
public enum KNNOJIECDCL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GCOHLLLMBHB
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
public enum HHCGOFCJMGL
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
public struct INLCLNCJGJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly HHCGOFCJMGL JMALHJBBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string OICPJIFJLPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6291960", Offset = "0x6290B60", VA = "0x186291960")]
	public INLCLNCJGJP(HHCGOFCJMGL KINMAPDAFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62918F0", Offset = "0x6290AF0", VA = "0x1862918F0")]
	public INLCLNCJGJP(HHCGOFCJMGL KINMAPDAFPJ, string NEEFDGFIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6291860", Offset = "0x6290A60", VA = "0x186291860")]
	public bool DGEJIPOLNAC(HHCGOFCJMGL LGBKNIFMDMI, string AENMIKCPOLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GEBIMNBICJA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GOEKCBGCKFE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62917A0", Offset = "0x62909A0", VA = "0x1862917A0")]
	public static void AGOFNEDKNEL(this AudioSource NELJINIAEPP, AudioRolloff KALFBNJNCPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KJNFIOFEMID
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6291A00", Offset = "0x6290C00", VA = "0x186291A00")]
	public static float IJGECFGNPCJ(float OOLOAKAKBDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6291A60", Offset = "0x6290C60", VA = "0x186291A60")]
	public static float ODDCADDBAAA(float OKFGNINOMML)
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
		[Cpp2IlInjected.Address(RVA = "0x6290D00", Offset = "0x628FF00", VA = "0x186290D00")]
		public float ICCMCNIOOCG(float PPMMHHHAAOE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6290FC0", Offset = "0x62901C0", VA = "0x186290FC0")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BPBBKMFGJGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DIKHCPPBLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, CMCAOCKOAAO> HMFHNMGOGEI();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, INLCLNCJGJP)> NJJGDNBOIDK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup HLHDBNICCJP(HHCGOFCJMGL KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup OAAHMBMAKMJ(INLCLNCJGJP JHBAFCNGCAP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource MENMHPNKPPI(RecRoomAudioClip NMIENHHGJGE, Transform GCBPLMECDEB, [Optional] AudioRolloff EPLCPJHGKIE, [Optional] Action<SFXAudioSource> MOGIIBABCLB, [Optional] INLCLNCJGJP? KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AEDNOLKNAAM(SFXAudioSource OAIBAMCKDCA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource HJIOJNCLEEM(RecRoomAudioClip[] DFLOIOEFIFH, bool KPCAFKCGNCA = false, float INCNLHFOLFM = 1f, [Optional] Action<SFXAudioSource> MOGIIBABCLB, [Optional] INLCLNCJGJP? KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource INIGLONHIHP(RecRoomAudioClip[] DFLOIOEFIFH, Transform GCBPLMECDEB, [Optional] AudioRolloff EPLCPJHGKIE, bool KPCAFKCGNCA = false, [Optional] Action<SFXAudioSource> MOGIIBABCLB, [Optional] INLCLNCJGJP? KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource ODJMMLNKEIP(RecRoomAudioClip BGPMKMAAFHH, Vector3 OGPMBFEEKPH, bool DNCCGMOOAJN, [Optional] AudioRolloff EPLCPJHGKIE, [Optional] Action<SFXAudioSource> MOGIIBABCLB, [Optional] INLCLNCJGJP? KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource ABFNKPNOMMH(RecRoomAudioClip AMNLOADDOCG, [Optional] Action<SFXAudioSource> MOGIIBABCLB, [Optional] INLCLNCJGJP? KINMAPDAFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MGBJAGNHOEE LDIIFFMNHPB(SFXAudioSource OAIBAMCKDCA, float NFGGHBGLLPA, float FEFLPFIAOEI);
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
			[Cpp2IlInjected.Address(RVA = "0x6291BC0", Offset = "0x6290DC0", VA = "0x186291BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6291C10", Offset = "0x6290E10", VA = "0x186291C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6291B70", Offset = "0x6290D70", VA = "0x186291B70")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6291B80", Offset = "0x6290D80", VA = "0x186291B80")]
		public RecRoomAudioClip(AudioClip AMNLOADDOCG)
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6291AA0", Offset = "0x6290CA0", VA = "0x186291AA0")]
		public bool EPBKCDKDJHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x834750", Offset = "0x833950", VA = "0x180834750")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, EFFDFKBKOKF.PJKHINJHFJN
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct BMBCOCHKPMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? BJHONKFDHIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float? LMIPDNDAHME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Vector3 ONCHOJGAIGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Transform JFEBLNFEHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AudioRolloff EPMHJJPPKKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float LCMOCLLPBIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float JJMBLPJBEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public HHCGOFCJMGL? JMALHJBBJBD;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float NPECLHDPMFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6291030", Offset = "0x6290230", VA = "0x186291030")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public HHCGOFCJMGL BALBOEKDJDH
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x6290FE0", Offset = "0x62901E0", VA = "0x186290FE0")]
				get
				{
					return default(HHCGOFCJMGL);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct DAPBHIEBOHM : IAsyncStateMachine
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
			public BMBCOCHKPMJ playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x62910B0", Offset = "0x62902B0", VA = "0x1862910B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6291670", Offset = "0x6290870", VA = "0x186291670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class EFIHPHBCNML : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public EFIHPHBCNML(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x62916D0", Offset = "0x62908D0", VA = "0x1862916D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6291750", Offset = "0x6290950", VA = "0x186291750", Slot = "8")]
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
		private Action<SFXAudioSource> DEFKHDBCMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GJCJPABGAJD KDDBJEGFCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private FFBJAHFPKAB DJIEAOJKFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private BPBBKMFGJGB KBDHGMDMFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float IGKICFDCCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float OJCOFGOPNCK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string BFIMKCMJJHN = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform JFEBLNFEHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int KIACEEGIIMH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6293260", Offset = "0x6292460", VA = "0x186293260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EGIMHHBCJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6293340", Offset = "0x6292540", VA = "0x186293340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ENGDPFNNAAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6293320", Offset = "0x6292520", VA = "0x186293320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float BJHONKFDHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6293360", Offset = "0x6292560", VA = "0x186293360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float JGIBLLAFJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6293280", Offset = "0x6292480", VA = "0x186293280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6291CA0", Offset = "0x6290EA0", VA = "0x186291CA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62924E0", Offset = "0x62916E0", VA = "0x1862924E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62931A0", Offset = "0x62923A0", VA = "0x1862931A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6293180", Offset = "0x6292380", VA = "0x186293180")]
		public void UpdateVolume(float CJDLCOKOKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6292F70", Offset = "0x6292170", VA = "0x186292F70")]
		public void UpdatePitch(float IAOJMNILHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6292ED0", Offset = "0x62920D0", VA = "0x186292ED0")]
		public void UpdateDopplerLevel(float AMMKBGDCCOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62930E0", Offset = "0x62922E0", VA = "0x1862930E0")]
		public void UpdateSpatialBlend(float IAMAEKKGAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6292E00", Offset = "0x6292000", VA = "0x186292E00")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62927C0", Offset = "0x62919C0", VA = "0x1862927C0")]
		public void Play(AudioClip AMNLOADDOCG, float CJDLCOKOKBF, Vector3 OGPMBFEEKPH, float CAFDNHPJDNP, float NABMHKLLLNP, AudioRolloff KALFBNJNCPH, [Optional] Action<SFXAudioSource> FNCNCBBBJHD, [Optional] INLCLNCJGJP? KINMAPDAFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6292670", Offset = "0x6291870", VA = "0x186292670")]
		[AsyncStateMachine(typeof(DAPBHIEBOHM))]
		public Task PlayAsync(AudioClip AMNLOADDOCG, BMBCOCHKPMJ NCOIMPLLEPP, CancellationToken GILHKFNDIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6291D70", Offset = "0x6290F70", VA = "0x186291D70")]
		private void EIGAMNEAHEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6292480", Offset = "0x6291680", VA = "0x186292480")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6292E30", Offset = "0x6292030", VA = "0x186292E30")]
		public void Scrub(float BAPODJDPLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6292E90", Offset = "0x6292090", VA = "0x186292E90")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6292D30", Offset = "0x6291F30", VA = "0x186292D30")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6292CB0", Offset = "0x6291EB0", VA = "0x186292CB0")]
		[IteratorStateMachine(typeof(EFIHPHBCNML))]
		public IEnumerator<AEBIBAEBDOJ> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62924D0", Offset = "0x62916D0", VA = "0x1862924D0", Slot = "4")]
		private void MKLLHLEEBNA(bool OAPODLLOLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
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
