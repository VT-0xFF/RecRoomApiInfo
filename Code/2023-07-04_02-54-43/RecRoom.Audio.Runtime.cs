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
public enum DNAEBLIONHN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DLMEKCIGJPE
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
public enum GLCFLLOBOEM
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
public struct MMNHCGBNKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly GLCFLLOBOEM KLCCGOPKEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string PKNJDNPCLMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71CC270", Offset = "0x71CA870", VA = "0x1871CC270")]
	public MMNHCGBNKAA(GLCFLLOBOEM HGDDFODJLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x71CC200", Offset = "0x71CA800", VA = "0x1871CC200")]
	public MMNHCGBNKAA(GLCFLLOBOEM HGDDFODJLIO, string PFAHHIANFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x71CC170", Offset = "0x71CA770", VA = "0x1871CC170")]
	public bool KJLFOCOIDIO(GLCFLLOBOEM HLEGAPKCBLH, string IAKPPMHLCPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CENHFGFPBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BAFDBOJNKMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int GMFBHPNBODF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, LDDEMNLKLDG> FNNPFDPCPMH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, MMNHCGBNKAA)> NECOCNFKKAJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup MJHJKDINLNC(GLCFLLOBOEM HGDDFODJLIO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup EFAGOBFOPGD(MMNHCGBNKAA OBKHJPENCAC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCHADGNBLEB(AudioSource FEJCHLCMJFB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource OJCPPNHLLJD(RecRoomAudioClip EEKFBMJEAGP, Transform IIANIEONLIJ, [Optional] AudioRolloff FBBLIGDJCKJ, [Optional] Action<SFXAudioSource> JMFLJPFEGFK, [Optional] MMNHCGBNKAA? HGDDFODJLIO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGNFLANHJNC(SFXAudioSource FEJCHLCMJFB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource DLCLMJPOCFC(RecRoomAudioClip[] LPHHLGJNEMC, bool DNIJJNAHEGA = false, float BKEILLFMCAF = 1f, [Optional] Action<SFXAudioSource> JMFLJPFEGFK, [Optional] MMNHCGBNKAA? HGDDFODJLIO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource LBMNPPFGAMD(RecRoomAudioClip[] LPHHLGJNEMC, Transform IIANIEONLIJ, [Optional] AudioRolloff FBBLIGDJCKJ, bool DNIJJNAHEGA = false, [Optional] Action<SFXAudioSource> JMFLJPFEGFK, [Optional] MMNHCGBNKAA? HGDDFODJLIO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource ENNHEAMEJLO(RecRoomAudioClip PPNIPBCCDNI, Vector3 DEGODPDOPJM, bool CCMIKFDPJDI, [Optional] AudioRolloff FBBLIGDJCKJ, [Optional] Action<SFXAudioSource> JMFLJPFEGFK, [Optional] MMNHCGBNKAA? HGDDFODJLIO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource EOAIBEFFMLG(RecRoomAudioClip IDHKPFNAGOL, [Optional] Action<SFXAudioSource> JMFLJPFEGFK, [Optional] MMNHCGBNKAA? HGDDFODJLIO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MPGDPLDMKPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const float OGMAGPCHOKI = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const float FEDEAEGHIJB = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71CC310", Offset = "0x71CA910", VA = "0x1871CC310")]
	public static float COIHBFDPEEK(float HFPCLBPEPIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x71CC360", Offset = "0x71CA960", VA = "0x1871CC360")]
	public static float MGOBIKHAHOC(float FBFJFPLHOFG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public MPGDPLDMKPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GHNPLCFFBAC
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71CBFE0", Offset = "0x71CA5E0", VA = "0x1871CBFE0")]
	public static void LCHADGNBLEB(this AudioSource NFDMKCAFGBJ, AudioRolloff MKAKKMLEOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71CC0A0", Offset = "0x71CA6A0", VA = "0x1871CC0A0")]
	public static void NFIJJBEGIFI(this AudioSource FEJCHLCMJFB, RecRoomAudioClip MNACBAHLINC)
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
		[Cpp2IlInjected.Address(RVA = "0x71CB5F0", Offset = "0x71C9BF0", VA = "0x1871CB5F0")]
		public float OKGILPBDEGI(float DGCKGDHMMMM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71CB8B0", Offset = "0x71C9EB0", VA = "0x1871CB8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x71CC790", Offset = "0x71CAD90", VA = "0x1871CC790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71CC820", Offset = "0x71CAE20", VA = "0x1871CC820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71CC730", Offset = "0x71CAD30", VA = "0x1871CC730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x71CC7D0", Offset = "0x71CADD0", VA = "0x1871CC7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71CC6C0", Offset = "0x71CACC0", VA = "0x1871CC6C0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71CC6E0", Offset = "0x71CACE0", VA = "0x1871CC6E0")]
		public RecRoomAudioClip(AudioClip IDHKPFNAGOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71CC550", Offset = "0x71CAB50", VA = "0x1871CC550")]
		public bool HMADAENKIEI(RecRoomAudioClip EJECOGCICOM)
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
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71CC480", Offset = "0x71CAA80", VA = "0x1871CC480")]
		public bool IMFBDIOCKPH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A2FF0", Offset = "0x9A15F0", VA = "0x1809A2FF0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, AOGNOBJANEJ.MJINJDOCONF
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct FKCNPPLAPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private const float GJMIIHOMGGM = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private const float NJCBPJIKDHD = 1f;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private const GLCFLLOBOEM DCANLNLJGBA = GLCFLLOBOEM.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float? AJHJKILNHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float? OEBMHCPHAPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Vector3 EOLBIDJIPHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Transform NKIHNJKDPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AudioRolloff ALBHOCDJIGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public float NKONAIMKCHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public float FHIBOJHKDEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public GLCFLLOBOEM? KLCCGOPKEMM;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float JGALFPCOJEO
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x71CBF50", Offset = "0x71CA550", VA = "0x1871CBF50")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public GLCFLLOBOEM KKCHHLEKINH
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x71CBF00", Offset = "0x71CA500", VA = "0x1871CBF00")]
				get
				{
					return default(GLCFLLOBOEM);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CAOCAAMDDFD : IAsyncStateMachine
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
			public FKCNPPLAPOJ playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public CAOCAAMDDFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71CB8D0", Offset = "0x71C9ED0", VA = "0x1871CB8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NOPCHAHPNJB : IEnumerator<NGCINEPJDAB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private NGCINEPJDAB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private NGCINEPJDAB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6400", Offset = "0x9E4A00", VA = "0x1809E6400")]
			[DebuggerHidden]
			public NOPCHAHPNJB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x71CC390", Offset = "0x71CA990", VA = "0x1871CC390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71CC440", Offset = "0x71CAA40", VA = "0x1871CC440", Slot = "8")]
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
		private Action<SFXAudioSource> OGOCGFIABAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private LABEIOOIHEC NBFGIFFNCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private GOAKOJLIONO AODPGMHDANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private BAFDBOJNKMJ JKEFKNEKBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float GAEDKCOFGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float BKNOHFKCPJA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string CKFELLGFGME = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform NKIHNJKDPJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int IJOPKFJBEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x71CDF70", Offset = "0x71CC570", VA = "0x1871CDF70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NJAEPDKFCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x71CE060", Offset = "0x71CC660", VA = "0x1871CE060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ECNBNPPBCJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71CE040", Offset = "0x71CC640", VA = "0x1871CE040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float AJHJKILNHPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71CE080", Offset = "0x71CC680", VA = "0x1871CE080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float BPFKJPIBEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71CDF90", Offset = "0x71CC590", VA = "0x1871CDF90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71CD050", Offset = "0x71CB650", VA = "0x1871CD050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71CD170", Offset = "0x71CB770", VA = "0x1871CD170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71CDE40", Offset = "0x71CC440", VA = "0x1871CDE40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71CDE20", Offset = "0x71CC420", VA = "0x1871CDE20")]
		public void UpdateVolume(float GDGDHIECCLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71CDC00", Offset = "0x71CC200", VA = "0x1871CDC00")]
		public void UpdatePitch(float LAMKEPKGMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71CDB60", Offset = "0x71CC160", VA = "0x1871CDB60")]
		public void UpdateDopplerLevel(float GOODFGHGLGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71CDD80", Offset = "0x71CC380", VA = "0x1871CDD80")]
		public void UpdateSpatialBlend(float EMIHBCOJHNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71CDA80", Offset = "0x71CC080", VA = "0x1871CDA80")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71CD4C0", Offset = "0x71CBAC0", VA = "0x1871CD4C0")]
		public void Play(AudioClip IDHKPFNAGOL, float GDGDHIECCLN, Vector3 DEGODPDOPJM, float NFAEAJINOIF, float KKPALCIOKIG, AudioRolloff MKAKKMLEOLD, [Optional] Action<SFXAudioSource> JMGPNNLLCGC, [Optional] MMNHCGBNKAA? HGDDFODJLIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71CD300", Offset = "0x71CB900", VA = "0x1871CD300")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(CAOCAAMDDFD))]
		public Task PlayAsync(AudioClip IDHKPFNAGOL, FKCNPPLAPOJ OBLIDICPNCF, CancellationToken OOAGLCBNIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71CC8A0", Offset = "0x71CAEA0", VA = "0x1871CC8A0")]
		private void AHLJKOJGHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71CD120", Offset = "0x71CB720", VA = "0x1871CD120")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x71CDAB0", Offset = "0x71CC0B0", VA = "0x1871CDAB0")]
		public void Scrub(float EKIGKJOOCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x71CDB20", Offset = "0x71CC120", VA = "0x1871CDB20")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71CD990", Offset = "0x71CBF90", VA = "0x1871CD990")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71CD920", Offset = "0x71CBF20", VA = "0x1871CD920")]
		[IteratorStateMachine(typeof(NOPCHAHPNJB))]
		public IEnumerator<NGCINEPJDAB> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71CD110", Offset = "0x71CB710", VA = "0x1871CD110", Slot = "4")]
		private void CPKBLMGNEJB(bool FGOINGEANAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71CDF10", Offset = "0x71CC510", VA = "0x1871CDF10")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
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
