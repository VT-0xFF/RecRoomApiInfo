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
public enum KKECPADCFND
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GOLCIANIIJG
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
public enum PBCJMLHOBGA
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
public struct CBLPOCIIMMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PBCJMLHOBGA IOOCBDFMLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DJKIAAHILAE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7277200", Offset = "0x7276200", VA = "0x187277200")]
	public CBLPOCIIMMH(PBCJMLHOBGA APJMBGGENCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72772A0", Offset = "0x72762A0", VA = "0x1872772A0")]
	public CBLPOCIIMMH(PBCJMLHOBGA APJMBGGENCH, string GENAJEJNLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7277170", Offset = "0x7276170", VA = "0x187277170")]
	public bool NCCNGKJLKIH(PBCJMLHOBGA AMOOHGHMIHF, string CIGAGHCPHGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LIIHCIFPDIN
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FABCPDEHDDD
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const int KLMOBAGHFBI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const int EJDHMAFOAMB = 2;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int LCOPDIBAACB = 2;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public FABCPDEHDDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MCKJLIAMDEP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BEKIHCONOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, ENEKLEEHPKH> KNOGGHNBMDK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, CBLPOCIIMMH)> IIJLLNOKPGL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup DAAKLHDGKEK(PBCJMLHOBGA APJMBGGENCH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup BPNIBFDCEGN(CBLPOCIIMMH PGHGHCDIALM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKGKFJMEDKP(AudioSource MFMLLENHKMN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource MMNIEPDFICN(RecRoomAudioClip FIOCAKMHNDJ, Transform PEMINEDHBGL, [Optional] AudioRolloff LNDNJPKLPNH, [Optional] Action<SFXAudioSource> DPCGKJOMBGB, [Optional] CBLPOCIIMMH? APJMBGGENCH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGDCOKFLINM(SFXAudioSource MFMLLENHKMN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource KHKFDABOPHI(RecRoomAudioClip[] POGCMNCHBLN, bool BHDOCLJEJEO = false, float JMHLCAGNKMF = 1f, [Optional] Action<SFXAudioSource> DPCGKJOMBGB, [Optional] CBLPOCIIMMH? APJMBGGENCH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource MDODNGCHLKJ(RecRoomAudioClip[] POGCMNCHBLN, Transform PEMINEDHBGL, [Optional] AudioRolloff LNDNJPKLPNH, bool BHDOCLJEJEO = false, [Optional] Action<SFXAudioSource> DPCGKJOMBGB, [Optional] CBLPOCIIMMH? APJMBGGENCH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource OGMMMIMKDIH(RecRoomAudioClip NPCKJKGBIGL, Vector3 HNEGIGNBMJE, bool JPGMNHNMFDM, [Optional] AudioRolloff LNDNJPKLPNH, [Optional] Action<SFXAudioSource> DPCGKJOMBGB, [Optional] CBLPOCIIMMH? APJMBGGENCH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource PPDNCJAIBJO(RecRoomAudioClip GAGDMMFKDAJ, [Optional] Action<SFXAudioSource> DPCGKJOMBGB, [Optional] CBLPOCIIMMH? APJMBGGENCH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IANKFNACJNF
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const float KPLMBDABAAE = -80f;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const float KKAPKBGLKPE = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7277940", Offset = "0x7276940", VA = "0x187277940")]
	public static float FGLJMEAEIOB(float GEGIJEAHNIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7277990", Offset = "0x7276990", VA = "0x187277990")]
	public static float GDLLMAODMKM(float PJPCHAGLHOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public IANKFNACJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LMLJOLOBBKH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7277B80", Offset = "0x7276B80", VA = "0x187277B80")]
	public static void PKGKFJMEDKP(this AudioSource PEGHMNALMCD, AudioRolloff DHBNDGBLKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7277AB0", Offset = "0x7276AB0", VA = "0x187277AB0")]
	public static void EPBOFBPEBHJ(this AudioSource MFMLLENHKMN, RecRoomAudioClip DEGJOKMCBJC)
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
		[Cpp2IlInjected.Address(RVA = "0x7276EB0", Offset = "0x7275EB0", VA = "0x187276EB0")]
		public float ILFOMLBHCDL(float JCGCOMMMLOD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7277150", Offset = "0x7276150", VA = "0x187277150")]
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
			[Cpp2IlInjected.Address(RVA = "0x7278030", Offset = "0x7277030", VA = "0x187278030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72780C0", Offset = "0x72770C0", VA = "0x1872780C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7277FD0", Offset = "0x7276FD0", VA = "0x187277FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7278070", Offset = "0x7277070", VA = "0x187278070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7277F60", Offset = "0x7276F60", VA = "0x187277F60")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7277F80", Offset = "0x7276F80", VA = "0x187277F80")]
		public RecRoomAudioClip(AudioClip GAGDMMFKDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7277DF0", Offset = "0x7276DF0", VA = "0x187277DF0")]
		public bool PKLANLJFCJB(RecRoomAudioClip BKLMLPFOMCO)
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7277D20", Offset = "0x7276D20", VA = "0x187277D20")]
		public bool BPPHKHBJNKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, OBJHJKGJMFC.KPBHINPKFMC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct PGFMDLBGBIN
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private const float AJMFMDKMIHK = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private const float APJCDFOHJJK = 1f;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private const PBCJMLHOBGA CCLLCKBJJDF = PBCJMLHOBGA.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float? IDPIAAHMDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public float? EKMAGMOLEHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Vector3 MAEOMNIBOJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public Transform IOOJLCODDMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioRolloff BINOLKBAFND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public float NNLPPIDJGOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public float JMFPGOGNPFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public PBCJMLHOBGA? IOOCBDFMLIA;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float JOHFCCEDMJC
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x7277C40", Offset = "0x7276C40", VA = "0x187277C40")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public PBCJMLHOBGA CFDDGPJKKMG
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7277CD0", Offset = "0x7276CD0", VA = "0x187277CD0")]
				get
				{
					return default(PBCJMLHOBGA);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class HKNLMHJIMNI : IAsyncStateMachine
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
			public PGFMDLBGBIN playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public HKNLMHJIMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7277310", Offset = "0x7276310", VA = "0x187277310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IPAPCGFPJHI : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private OJAHJFHMFIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public IPAPCGFPJHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x72779C0", Offset = "0x72769C0", VA = "0x1872779C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7277A70", Offset = "0x7276A70", VA = "0x187277A70", Slot = "8")]
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
		private Action<SFXAudioSource> INBAHJPFKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private BEKPINHCBFC BHMKKAFKCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private IMBCFAJLPLN NNDJCOBKGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MCKJLIAMDEP DFIOPFFHOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float CBEBLPCOKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float LKILMHJHILN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string ANLMGHGCPLE = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform IOOJLCODDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DJAKFKEDKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x72797F0", Offset = "0x72787F0", VA = "0x1872797F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FBNMMNANIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72798E0", Offset = "0x72788E0", VA = "0x1872798E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PMGLOIKKOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x72798C0", Offset = "0x72788C0", VA = "0x1872798C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float IDPIAAHMDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7279900", Offset = "0x7278900", VA = "0x187279900")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float KMMLCLEBDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7279810", Offset = "0x7278810", VA = "0x187279810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7278140", Offset = "0x7277140", VA = "0x187278140")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7278A00", Offset = "0x7277A00", VA = "0x187278A00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72796C0", Offset = "0x72786C0", VA = "0x1872796C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72796A0", Offset = "0x72786A0", VA = "0x1872796A0")]
		public void UpdateVolume(float MKEEAJMDPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7279480", Offset = "0x7278480", VA = "0x187279480")]
		public void UpdatePitch(float HBJEKKFBDBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72793E0", Offset = "0x72783E0", VA = "0x1872793E0")]
		public void UpdateDopplerLevel(float JJOKADCKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7279600", Offset = "0x7278600", VA = "0x187279600")]
		public void UpdateSpatialBlend(float BMANINOACKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7279300", Offset = "0x7278300", VA = "0x187279300")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7278D50", Offset = "0x7277D50", VA = "0x187278D50")]
		public void Play(AudioClip GAGDMMFKDAJ, float MKEEAJMDPPD, Vector3 HNEGIGNBMJE, float KEOPIDEOOEK, float IDNBDPFCMCK, AudioRolloff DHBNDGBLKJN, [Optional] Action<SFXAudioSource> LLOKOMKLENF, [Optional] CBLPOCIIMMH? APJMBGGENCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7278B90", Offset = "0x7277B90", VA = "0x187278B90")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HKNLMHJIMNI))]
		public Task PlayAsync(AudioClip GAGDMMFKDAJ, PGFMDLBGBIN LBNPBDPMLND, CancellationToken OAGBBBCDIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7278200", Offset = "0x7277200", VA = "0x187278200")]
		private void CPKMIDIBOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72789B0", Offset = "0x72779B0", VA = "0x1872789B0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7279330", Offset = "0x7278330", VA = "0x187279330")]
		public void Scrub(float AILHHDAIAFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72793A0", Offset = "0x72783A0", VA = "0x1872793A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7279210", Offset = "0x7278210", VA = "0x187279210")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72791A0", Offset = "0x72781A0", VA = "0x1872791A0")]
		[IteratorStateMachine(typeof(IPAPCGFPJHI))]
		public IEnumerator<OJAHJFHMFIA> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72789A0", Offset = "0x72779A0", VA = "0x1872789A0", Slot = "4")]
		private void JDKBACHBCDM(bool MHCBMAAPDGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7279790", Offset = "0x7278790", VA = "0x187279790")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
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
