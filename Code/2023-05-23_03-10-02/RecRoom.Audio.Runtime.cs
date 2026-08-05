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
public enum DABAIGCNBGE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EANNMHPOFHG
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
public enum GOBKHAMDOEC
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
public struct PHCCENKPEJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GOBKHAMDOEC GGBBBNOPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string JNMIFDDFKIM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x169D200", Offset = "0x169C600", VA = "0x18169D200")]
	public PHCCENKPEJB(GOBKHAMDOEC FBADOLNEEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x169D2A0", Offset = "0x169C6A0", VA = "0x18169D2A0")]
	public PHCCENKPEJB(GOBKHAMDOEC FBADOLNEEEA, string JLFGLMEIOPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x169D170", Offset = "0x169C570", VA = "0x18169D170")]
	public bool GHBILINDPHP(GOBKHAMDOEC KOCIGCNHPLH, string HBLBALMPBMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DNKHDJMMAKC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DLDBMJICAHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KHAJHFDMIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, EEGKEOAMMJM> FGJGBHOFPLB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, PHCCENKPEJB)> LIHINONPDII();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup NPACBMNMPFJ(GOBKHAMDOEC FBADOLNEEEA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup GIOLOIIKEDB(PHCCENKPEJB HCMPGGDCDNK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAJNAMLJGGJ(AudioSource OCMMIMFIKCF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource OKBKCPCDIOG(RecRoomAudioClip KHIAKKPIKDF, Transform KOJLGDEFPCJ, [Optional] AudioRolloff KFOELHPAPND, [Optional] Action<SFXAudioSource> OBBBIOGALCJ, [Optional] PHCCENKPEJB? FBADOLNEEEA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void INDGAAOBNKO(SFXAudioSource OCMMIMFIKCF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource JGKBAEOJNHE(RecRoomAudioClip[] DEGJGHGKHLD, bool EOPFFOPKPCJ = false, float IFHBNIFIJNC = 1f, [Optional] Action<SFXAudioSource> OBBBIOGALCJ, [Optional] PHCCENKPEJB? FBADOLNEEEA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource OOGGKHIMKEH(RecRoomAudioClip[] DEGJGHGKHLD, Transform KOJLGDEFPCJ, [Optional] AudioRolloff KFOELHPAPND, bool EOPFFOPKPCJ = false, [Optional] Action<SFXAudioSource> OBBBIOGALCJ, [Optional] PHCCENKPEJB? FBADOLNEEEA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource AMAAAOBPAPP(RecRoomAudioClip JFLJPDEMCFE, Vector3 PIFKAMCJGGD, bool HMGHGFHMDKJ, [Optional] AudioRolloff KFOELHPAPND, [Optional] Action<SFXAudioSource> OBBBIOGALCJ, [Optional] PHCCENKPEJB? FBADOLNEEEA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource NNDNHLCHBKO(RecRoomAudioClip EFNLDDPJLAK, [Optional] Action<SFXAudioSource> OBBBIOGALCJ, [Optional] PHCCENKPEJB? FBADOLNEEEA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NCPCBMAAJPN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const float OOEKKDEABIJ = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const float FOEFLBMJDCL = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x169D010", Offset = "0x169C410", VA = "0x18169D010")]
	public static float CFHDGGNKGFM(float OMBANBODFAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x169D060", Offset = "0x169C460", VA = "0x18169D060")]
	public static float GIEEBHIGOCA(float HPDLFFAHEFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public NCPCBMAAJPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ELEEPFBKBJK
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x169CE60", Offset = "0x169C260", VA = "0x18169CE60")]
	public static void NAJNAMLJGGJ(this AudioSource BODJNDGPEOP, AudioRolloff JNGJNIAHOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x169CD90", Offset = "0x169C190", VA = "0x18169CD90")]
	public static void EKEKKBDBEGC(this AudioSource OCMMIMFIKCF, RecRoomAudioClip BGPKMBFCLFC)
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
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

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x169C490", Offset = "0x169B890", VA = "0x18169C490")]
		public float CABLOIBMLOC(float FNENONJMBAP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x169C750", Offset = "0x169BB50", VA = "0x18169C750")]
		public AudioRolloff()
		{
		}
	}
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
		[Header("Pitch")]
		[Range(0f, 0f)]
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
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x169D620", Offset = "0x169CA20", VA = "0x18169D620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x169D6B0", Offset = "0x169CAB0", VA = "0x18169D6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x169D5C0", Offset = "0x169C9C0", VA = "0x18169D5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x169D660", Offset = "0x169CA60", VA = "0x18169D660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x169D550", Offset = "0x169C950", VA = "0x18169D550")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x169D570", Offset = "0x169C970", VA = "0x18169D570")]
		public RecRoomAudioClip(AudioClip EFNLDDPJLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x169D3E0", Offset = "0x169C7E0", VA = "0x18169D3E0")]
		public bool HEMFDKICHNE(RecRoomAudioClip CCJMBGJFGLH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x169D310", Offset = "0x169C710", VA = "0x18169D310")]
		public bool DHBNFOJCDFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBBA390", Offset = "0xBB9790", VA = "0x180BBA390")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, AIIHBNLGFAN.MPJMCMKPKDE
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct ODFFNBONMKB
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private const float JICJCPLEDMC = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private const float GEBIHDFEGCL = 1f;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private const GOBKHAMDOEC KMLEJLNBODF = GOBKHAMDOEC.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float? DHLGHBGPMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float? ECAKHADABLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Vector3 BFCIMPDFGBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Transform PBCFELCJFGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AudioRolloff ANLALGPCOEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public float JGKFLLJPPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public float BBKNEAMCBBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public GOBKHAMDOEC? GGBBBNOPKLO;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float BPIEBHLIAAC
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x169D0E0", Offset = "0x169C4E0", VA = "0x18169D0E0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public GOBKHAMDOEC AAPCOMFHJGO
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x169D090", Offset = "0x169C490", VA = "0x18169D090")]
				get
				{
					return default(GOBKHAMDOEC);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DONNHBKKDEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ODFFNBONMKB playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private float <pitch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public DONNHBKKDEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x169C770", Offset = "0x169BB70", VA = "0x18169C770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JMNAIMCABOL : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private IPNFOPMMOKI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
			[DebuggerHidden]
			public JMNAIMCABOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x169CF20", Offset = "0x169C320", VA = "0x18169CF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x169CFD0", Offset = "0x169C3D0", VA = "0x18169CFD0", Slot = "8")]
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
		private Action<SFXAudioSource> CNDLPNAAAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DAPNFHHMCEG KLFBNFGJKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[BCPMGDDGKGM(BGDDCFKMKBJ.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private FAPBONLDLGM OCOCEFKHDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private DLDBMJICAHK ELDKMGGKCDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float HMAFHIILPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float LJAFBENHFMA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string OMOKEEABNMK = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform PBCFELCJFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int DLMBKHPNFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x169EE10", Offset = "0x169E210", VA = "0x18169EE10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PCMKGDKNLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x169EF00", Offset = "0x169E300", VA = "0x18169EF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CBDPIBGJMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x169EEE0", Offset = "0x169E2E0", VA = "0x18169EEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float DHLGHBGPMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x169EF20", Offset = "0x169E320", VA = "0x18169EF20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float CGOOKDIEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x169EE30", Offset = "0x169E230", VA = "0x18169EE30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x169D730", Offset = "0x169CB30", VA = "0x18169D730")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x169E000", Offset = "0x169D400", VA = "0x18169E000")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x169ECE0", Offset = "0x169E0E0", VA = "0x18169ECE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x169ECC0", Offset = "0x169E0C0", VA = "0x18169ECC0")]
		public void UpdateVolume(float LJDPHLGINAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x169EAA0", Offset = "0x169DEA0", VA = "0x18169EAA0")]
		public void UpdatePitch(float JNCCCCODBNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x169EA00", Offset = "0x169DE00", VA = "0x18169EA00")]
		public void UpdateDopplerLevel(float NODDEMEAKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x169EC20", Offset = "0x169E020", VA = "0x18169EC20")]
		public void UpdateSpatialBlend(float JOHMCBOMFFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x169E920", Offset = "0x169DD20", VA = "0x18169E920")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x169E360", Offset = "0x169D760", VA = "0x18169E360")]
		public void Play(AudioClip EFNLDDPJLAK, float LJDPHLGINAC, Vector3 PIFKAMCJGGD, float CPJLJBHCOOD, float MNFBPPPABNA, AudioRolloff JNGJNIAHOGJ, [Optional] Action<SFXAudioSource> MLOGBHFHCJB, [Optional] PHCCENKPEJB? FBADOLNEEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x169E1A0", Offset = "0x169D5A0", VA = "0x18169E1A0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DONNHBKKDEF))]
		public Task PlayAsync(AudioClip EFNLDDPJLAK, ODFFNBONMKB OIBGICFMCOE, CancellationToken EMJFDFLJKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x169D800", Offset = "0x169CC00", VA = "0x18169D800")]
		private void KOMNAMNIKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x169DFB0", Offset = "0x169D3B0", VA = "0x18169DFB0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x169E950", Offset = "0x169DD50", VA = "0x18169E950")]
		public void Scrub(float BPCFECOOAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x169E9C0", Offset = "0x169DDC0", VA = "0x18169E9C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x169E830", Offset = "0x169DC30", VA = "0x18169E830")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x169E7C0", Offset = "0x169DBC0", VA = "0x18169E7C0")]
		[IteratorStateMachine(typeof(JMNAIMCABOL))]
		public IEnumerator<IPNFOPMMOKI> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x169D7F0", Offset = "0x169CBF0", VA = "0x18169D7F0", Slot = "4")]
		private void JNLJEGLFAMC(bool BIECHBLBGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x169EDB0", Offset = "0x169E1B0", VA = "0x18169EDB0")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
