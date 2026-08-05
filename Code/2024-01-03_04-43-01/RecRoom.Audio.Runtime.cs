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
public enum LLCJPNKAMEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BNLGNLDHDIB
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
public enum OEFIAEGJICI
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
public struct MEDGPIKJOGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly OEFIAEGJICI NKIFMIKKHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string EMOBHNOOEBH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D23BC0", Offset = "0x5D227C0", VA = "0x185D23BC0")]
	public MEDGPIKJOGH(OEFIAEGJICI NIFEIEHLCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D23C60", Offset = "0x5D22860", VA = "0x185D23C60")]
	public MEDGPIKJOGH(OEFIAEGJICI NIFEIEHLCOK, string MLLDJLKBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D23B30", Offset = "0x5D22730", VA = "0x185D23B30")]
	public bool OELJPOAIEMC(OEFIAEGJICI AKLMNLFEEJF, string BNNCDMMPCPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MICOMCOPDLI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LENOLEBFCCA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D23A70", Offset = "0x5D22670", VA = "0x185D23A70")]
	public static void JDDFNAGMLAD(this AudioSource ODHJFCMIAKA, AudioRolloff OPHMPLPAPPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GLBCGOHPLBO
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D239D0", Offset = "0x5D225D0", VA = "0x185D239D0")]
	public static float JDJCPGLLOGI(float NHFKCNCFLNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D23A30", Offset = "0x5D22630", VA = "0x185D23A30")]
	public static float PMMDHIIFMKC(float HMADMALCKMK)
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
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D23550", Offset = "0x5D22150", VA = "0x185D23550")]
		public float EMJHACCHONB(float MFDFFBFAEPE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D23810", Offset = "0x5D22410", VA = "0x185D23810")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JMIIPPABBNH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int MFNGLJLEMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, JCCJFAAJOOF> LNFFFINJPPI();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, MEDGPIKJOGH)> MMIIOBGINED();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup KJIPCAMPPFD(OEFIAEGJICI NIFEIEHLCOK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup BHIDDFGMFHB(MEDGPIKJOGH CKKJGHLJLEB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource CGHCMODCDKO(RecRoomAudioClip PIAOOCDBJHH, Transform LNECAPBDEHM, [Optional] AudioRolloff BKAGHABKMPG, [Optional] Action<SFXAudioSource> HCLDEFGCFKL, [Optional] MEDGPIKJOGH? NIFEIEHLCOK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLPGFOGFAIL(SFXAudioSource ALPCBDHLGEP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource MHAHJFCPMDJ(RecRoomAudioClip[] EOMHMNHADKE, bool EPBHDJIKDBE = false, float KNJGBHJOKGE = 1f, [Optional] Action<SFXAudioSource> HCLDEFGCFKL, [Optional] MEDGPIKJOGH? NIFEIEHLCOK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource MKFPOGICFPN(RecRoomAudioClip[] EOMHMNHADKE, Transform LNECAPBDEHM, [Optional] AudioRolloff BKAGHABKMPG, bool EPBHDJIKDBE = false, [Optional] Action<SFXAudioSource> HCLDEFGCFKL, [Optional] MEDGPIKJOGH? NIFEIEHLCOK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource PFKMFKNENGC(RecRoomAudioClip CKNGMIEEAAL, Vector3 BHCNJFDJBME, bool EBOAFCGDLCA, [Optional] AudioRolloff BKAGHABKMPG, [Optional] Action<SFXAudioSource> HCLDEFGCFKL, [Optional] MEDGPIKJOGH? NIFEIEHLCOK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource LIMKHMEHGNF(RecRoomAudioClip MJGEHNLJJMN, [Optional] Action<SFXAudioSource> HCLDEFGCFKL, [Optional] MEDGPIKJOGH? NIFEIEHLCOK);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5D24410", Offset = "0x5D23010", VA = "0x185D24410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5D24460", Offset = "0x5D23060", VA = "0x185D24460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D243C0", Offset = "0x5D22FC0", VA = "0x185D243C0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D243D0", Offset = "0x5D22FD0", VA = "0x185D243D0")]
		public RecRoomAudioClip(AudioClip MJGEHNLJJMN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5D242F0", Offset = "0x5D22EF0", VA = "0x185D242F0")]
		public bool IMIHEDKOHPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6A90", Offset = "0x7F5690", VA = "0x1807F6A90")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, AJJDCOMNPCE.GLAIOONBEOL
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct DIGJIINLIEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? OBLGKHMELIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? HICNBOFGGEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 OOCCFIJPLHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform MGPOPFPIFKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff PBFHDPDPDJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float PILANOLDBMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float JGILCDPMIBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public OEFIAEGJICI? NKIFMIKKHDL;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float DDHHMGGMOBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x5D23950", Offset = "0x5D22550", VA = "0x185D23950")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public OEFIAEGJICI BKMKENMAKBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x5D23900", Offset = "0x5D22500", VA = "0x185D23900")]
				get
				{
					return default(OEFIAEGJICI);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct OBICINGCIME : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public DIGJIINLIEP playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D23CD0", Offset = "0x5D228D0", VA = "0x185D23CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5D24290", Offset = "0x5D22E90", VA = "0x185D24290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class CLNPMPHJKJK : IEnumerator<MJMKCFLBGFK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private MJMKCFLBGFK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private MJMKCFLBGFK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
			[DebuggerHidden]
			public CLNPMPHJKJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5D23830", Offset = "0x5D22430", VA = "0x185D23830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5D238B0", Offset = "0x5D224B0", VA = "0x185D238B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> KDBNHBDMJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private PABKPJDFADP KHHEFBCBMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[AJIIAMJDEPI(GNDHFGBAEMN.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private OGBLNGLGIDJ IAJNPFBJPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JMIIPPABBNH AHKKLINLIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float ACGEIAGPHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float DADNEMLGOKF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string JPGKHONLCKP = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform MGPOPFPIFKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int BICEPECLEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5D25AA0", Offset = "0x5D246A0", VA = "0x185D25AA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ALGCLDFNMAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5D25B80", Offset = "0x5D24780", VA = "0x185D25B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool MOKFCAKBGAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5D25B60", Offset = "0x5D24760", VA = "0x185D25B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float OBLGKHMELIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5D25BA0", Offset = "0x5D247A0", VA = "0x185D25BA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float JJNIGKDDCHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5D25AC0", Offset = "0x5D246C0", VA = "0x185D25AC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D244F0", Offset = "0x5D230F0", VA = "0x185D244F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5D24D20", Offset = "0x5D23920", VA = "0x185D24D20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D259E0", Offset = "0x5D245E0", VA = "0x185D259E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D259C0", Offset = "0x5D245C0", VA = "0x185D259C0")]
		public void UpdateVolume(float EBNLDJBCHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5D257B0", Offset = "0x5D243B0", VA = "0x185D257B0")]
		public void UpdatePitch(float JIIDCCGCBKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D25710", Offset = "0x5D24310", VA = "0x185D25710")]
		public void UpdateDopplerLevel(float DCGANHACOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D25920", Offset = "0x5D24520", VA = "0x185D25920")]
		public void UpdateSpatialBlend(float JLMKHINBMKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D25640", Offset = "0x5D24240", VA = "0x185D25640")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D25000", Offset = "0x5D23C00", VA = "0x185D25000")]
		public void Play(AudioClip MJGEHNLJJMN, float EBNLDJBCHCP, Vector3 BHCNJFDJBME, float MLPGKIDJNGE, float BGNPGGKCACL, AudioRolloff OPHMPLPAPPL, [Optional] Action<SFXAudioSource> MJFFACHHGDP, [Optional] MEDGPIKJOGH? NIFEIEHLCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D24EB0", Offset = "0x5D23AB0", VA = "0x185D24EB0")]
		[AsyncStateMachine(typeof(OBICINGCIME))]
		public Task PlayAsync(AudioClip MJGEHNLJJMN, DIGJIINLIEP BNAGHKHHJFL, CancellationToken BJFJMBIBKLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D245C0", Offset = "0x5D231C0", VA = "0x185D245C0")]
		private void DNDLGGDMKGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D24CD0", Offset = "0x5D238D0", VA = "0x185D24CD0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D25670", Offset = "0x5D24270", VA = "0x185D25670")]
		public void Scrub(float OJANOJHOJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D256D0", Offset = "0x5D242D0", VA = "0x185D256D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D25570", Offset = "0x5D24170", VA = "0x185D25570")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D254F0", Offset = "0x5D240F0", VA = "0x185D254F0")]
		[IteratorStateMachine(typeof(CLNPMPHJKJK))]
		public IEnumerator<MJMKCFLBGFK> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5D24CC0", Offset = "0x5D238C0", VA = "0x185D24CC0", Slot = "4")]
		private void HENKPCBAJFK(bool BNMAAIDFKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
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
