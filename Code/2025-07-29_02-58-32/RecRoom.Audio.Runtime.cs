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
using RecRoom.Core.Pools;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EGPOPHJDKLC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8119040", Offset = "0x8117A40", VA = "0x188119040")]
	public static void JHOPCHLOLDM(this AudioSource AIAJMLDBDLM, AudioRolloff ACABMDBDNPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GMNKKLDJKOD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8119230", Offset = "0x8117C30", VA = "0x188119230")]
	public static float GPKGLFOEKHB(float FGABNJDJGIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8119290", Offset = "0x8117C90", VA = "0x188119290")]
	public static float IAHEDPCNGBE(float ILNFCFFLPHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81191D0", Offset = "0x8117BD0", VA = "0x1881191D0")]
	public static float EBGDNINDPND(float[] GPCDCFCPGFK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ECBNLFMBINN]
public enum MEPOCKBKDKI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	MaxPriority = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Music_2D = 5,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	SFX_2D = 15,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Voice_AI = 50,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Voice_2D = 100,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Ambient_2D = 115,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Default = 128,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LowestPriority = byte.MaxValue
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8118160", Offset = "0x8116B60", VA = "0x188118160")]
		public float IFOMLAGOIAC(float AEMEPCOOFBB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8118430", Offset = "0x8116E30", VA = "0x188118430")]
		public AudioRolloff()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AudioSourceSimpleLevelMeter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int HCGFAAKFELG = 15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		private AudioSource source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JOOLDAFNLND<float> AFDJIDIHBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int MKFOHICGGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private float NNGMFPHCJED;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int JDBODHIJCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8118860", Offset = "0x8117260", VA = "0x188118860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float CGCCBMCJPMM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x81187D0", Offset = "0x81171D0", VA = "0x1881187D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float EOBKMOHELCN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x81187A0", Offset = "0x81171A0", VA = "0x1881187A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD796E0", Offset = "0xD780E0", VA = "0x180D796E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private bool KGBJENKIAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8118450", Offset = "0x8116E50", VA = "0x188118450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81186C0", Offset = "0x81170C0", VA = "0x1881186C0")]
		public void RuntimeInitAudioSource()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81184D0", Offset = "0x8116ED0", VA = "0x1881184D0")]
		private void OnAudioFilterRead(float[] GPCDCFCPGFK, int FFFBBGDMCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8118710", Offset = "0x8117110", VA = "0x188118710")]
		public AudioSourceSimpleLevelMeter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KPGHENBLKEI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int FCMMMPMMKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, IGHHDAKNEEA> FFFLEFGCHNB();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, IGHHDAKNEEA> CMILGKEAAAE();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, KFHFGBJCLPC)> NHMBPENJPHA();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KFHFGBJCLPC EIAJNCMACOA();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup EEFMMMOCMDL(NEAPMCHDCGK GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup IFEADGAGIEO(KFHFGBJCLPC NDJPAHLEMNK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource JKEBJNCNFPP(RecRoomAudioClip AOOBFEHGIDH, Transform BDBDCDEACJC, [Optional] AudioRolloff JLIOGLNGAIK, [Optional] Action<SFXAudioSource> NGGMIJCPLPL, [Optional] KFHFGBJCLPC? GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GFALLJGPIGF(SFXAudioSource KBMMHDOGEHK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource DKPFGOEOAII(RecRoomAudioClip[] OJAEICGBMDM, bool DJPBKDFPOBF = false, float DENNJIPNIOE = 1f, [Optional] Action<SFXAudioSource> NGGMIJCPLPL, [Optional] KFHFGBJCLPC? GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource KJDPMHHFOIA(RecRoomAudioClip[] OJAEICGBMDM, Transform BDBDCDEACJC, [Optional] AudioRolloff JLIOGLNGAIK, bool DJPBKDFPOBF = false, [Optional] Action<SFXAudioSource> NGGMIJCPLPL, [Optional] KFHFGBJCLPC? GEBANPLEEEG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource OBKFCNBHEOM(RecRoomAudioClip MPADPMEINDD, Vector3 AMHNILIPNIK, [Optional] AudioRolloff JLIOGLNGAIK, [Optional] Action<SFXAudioSource> NGGMIJCPLPL, [Optional] KFHFGBJCLPC? GEBANPLEEEG, bool GINDIDPLJAH = false, bool DCPLGHKAIGI = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource PEICJLFLKOK(RecRoomAudioClip MIINEKHOHCC, [Optional] Action<SFXAudioSource> NGGMIJCPLPL, [Optional] KFHFGBJCLPC? GEBANPLEEEG, bool GINDIDPLJAH = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x81192D0", Offset = "0x8117CD0", VA = "0x1881192D0", Slot = "12")]
	ObjectPool.PMDAHCLAPBK<SFXAudioSource> IMOPNKFEEFB(bool KNBEDBOIDGN)
	{
		return default(ObjectPool.PMDAHCLAPBK<SFXAudioSource>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ObjectPool.PMDAHCLAPBK<SFXAudioSource> FEFADNJLBCE();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ObjectPool.PMDAHCLAPBK<SFXAudioSource> GNLHHNOCBNJ();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NNFEFJFFOPD APPEHBJGIBI(SFXAudioSource KBMMHDOGEHK, float KHFIBHBBFHK, float KHJNAGFHPGB);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Volume")]
		[SerializeField]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8119500", Offset = "0x8117F00", VA = "0x188119500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8119550", Offset = "0x8117F50", VA = "0x188119550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81194B0", Offset = "0x8117EB0", VA = "0x1881194B0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81194C0", Offset = "0x8117EC0", VA = "0x1881194C0")]
		public RecRoomAudioClip(AudioClip MIINEKHOHCC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81193F0", Offset = "0x8117DF0", VA = "0x1881193F0")]
		public bool IBNGKLOIFCJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD12090", Offset = "0xD10A90", VA = "0x180D12090")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		protected SFXTrack.BJALDEAEJCO trackType;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8118130", Offset = "0x8116B30", VA = "0x188118130")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public SFXTrack.BJALDEAEJCO TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
			get
			{
				return default(SFXTrack.BJALDEAEJCO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8117E90", Offset = "0x8116890", VA = "0x188117E90")]
		protected void BPNGHIHHAFN(string NKEANKNENKE, SFXTrack.BJALDEAEJCO FMKGACFEMOF, Guid DNLDANFOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8118020", Offset = "0x8116A20", VA = "0x188118020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8117F40", Offset = "0x8116940", VA = "0x188117F40", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8118070", Offset = "0x8116A70", VA = "0x188118070")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAD7480", Offset = "0xAD5E80", VA = "0x180AD7480", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81195E0", Offset = "0x8117FE0", VA = "0x1881195E0")]
		public void BPNGHIHHAFN(string NKEANKNENKE, SFXTrack.BJALDEAEJCO FMKGACFEMOF, Guid DNLDANFOOJK, float MMHGFIDJNJG, AssetReference JNGIGOJOHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8118070", Offset = "0x8116A70", VA = "0x188118070")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DIPHBALHEPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
			public DIPHBALHEPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8118F10", Offset = "0x8117910", VA = "0x188118F10")]
			internal AFFEEHDLACO<Guid>.AMBOAOFLBPN FGKNPNHGLJB(RuntimeAddressableSFXTrack track)
			{
				return default(AFFEEHDLACO<Guid>.AMBOAOFLBPN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private AFFEEHDLACO<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x811B490", Offset = "0x8119E90", VA = "0x18811B490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AFFEEHDLACO<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x811B300", Offset = "0x8119D00", VA = "0x18811B300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x811AEF0", Offset = "0x81198F0", VA = "0x18811AEF0")]
		public FDLGIOOGFEJ<AudioClip> JMMHLAGPGLA(Guid BPPCHKNAPCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x811B1C0", Offset = "0x8119BC0", VA = "0x18811B1C0")]
		private FDLGIOOGFEJ<AudioClip> JMMHLAGPGLA(AssetReference NEALDKOJLCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x811B260", Offset = "0x8119C60", VA = "0x18811B260")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SFXAudioSource : MonoBehaviour, MMDKMBOCGGO.LBJKCNIABMM
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct FLKCCKCMJEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? BLAIGIMNACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float? ADPIMAHABKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Vector3 EFCKLEHNMMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Transform LJODOLCIKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AudioRolloff PPOIOFKKMKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float JKMFAFDOCMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public float LNOGHPANGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public NEAPMCHDCGK? CKKHJJKOGEC;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public float OKGDIABIPLO
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x8119100", Offset = "0x8117B00", VA = "0x188119100")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public NEAPMCHDCGK KDMPEKIEMPE
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x8119180", Offset = "0x8117B80", VA = "0x188119180")]
				get
				{
					return default(NEAPMCHDCGK);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct DEELCDBBJAJ : IAsyncStateMachine
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
			public FLKCCKCMJEI playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x81188F0", Offset = "0x81172F0", VA = "0x1881188F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8118EB0", Offset = "0x81178B0", VA = "0x188118EB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class DPBMAMLPGOL : IEnumerator<BHOPOIJKEJE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private BHOPOIJKEJE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private BHOPOIJKEJE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000061")]
				[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
			[DebuggerHidden]
			public DPBMAMLPGOL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8118F70", Offset = "0x8117970", VA = "0x188118F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8118FF0", Offset = "0x81179F0", VA = "0x188118FF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static bool OptimizePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> IAGBOKLOMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private DAMMDADGLAC DIGDKILHKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool IKAEGFAPCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[OICBHOIKJDP(MGLGMLBODOF.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DBKGBEHKCFL NLMEIMLNPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private KPGHENBLKEI HHDPFPDGCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool? ECPJBHIDGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float KHLANNAMAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float ONKFDEEOJMA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string MKFHONABFAD = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform LJODOLCIKMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA88330", Offset = "0xA86D30", VA = "0x180A88330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA88310", Offset = "0xA86D10", VA = "0x180A88310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public AudioSource CPBHNJPBMAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA91C70", Offset = "0xA90670", VA = "0x180A91C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool GBGOMKMDLHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x811A090", Offset = "0x8118A90", VA = "0x18811A090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int LNCALIABABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x811ADD0", Offset = "0x81197D0", VA = "0x18811ADD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool EMHEMAJJPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x811AEB0", Offset = "0x81198B0", VA = "0x18811AEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool EHDIJFJBFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x811AE90", Offset = "0x8119890", VA = "0x18811AE90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float BLAIGIMNACJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x811AED0", Offset = "0x81198D0", VA = "0x18811AED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float HAGLJMFMICD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x811ADF0", Offset = "0x81197F0", VA = "0x18811ADF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81196B0", Offset = "0x81180B0", VA = "0x1881196B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8119F00", Offset = "0x8118900", VA = "0x188119F00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x811ACF0", Offset = "0x81196F0", VA = "0x18811ACF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x811ACD0", Offset = "0x81196D0", VA = "0x18811ACD0")]
		public void UpdateVolume(float HACEBHCGJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x811AAC0", Offset = "0x81194C0", VA = "0x18811AAC0")]
		public void UpdatePitch(float CCCFJIKPBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x811AA20", Offset = "0x8119420", VA = "0x18811AA20")]
		public void UpdateDopplerLevel(float DECANLEIMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x811AC30", Offset = "0x8119630", VA = "0x18811AC30")]
		public void UpdateSpatialBlend(float IBMIHOBGJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x811A950", Offset = "0x8119350", VA = "0x18811A950")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x811A2D0", Offset = "0x8118CD0", VA = "0x18811A2D0")]
		public void Play(AudioClip MIINEKHOHCC, float HACEBHCGJMP, Vector3 AMHNILIPNIK, float OENBONCCAME, float CIDEDPNNLOF, AudioRolloff ACABMDBDNPG, [Optional] Action<SFXAudioSource> MJEKOHPDLAB, [Optional] KFHFGBJCLPC? GEBANPLEEEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x811A180", Offset = "0x8118B80", VA = "0x18811A180")]
		[AsyncStateMachine(typeof(DEELCDBBJAJ))]
		public Task PlayAsync(AudioClip MIINEKHOHCC, FLKCCKCMJEI GBLBKNMAJML, CancellationToken OMJKEHOJJFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81197A0", Offset = "0x81181A0", VA = "0x1881197A0")]
		private void EGMIJGJICGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8119EB0", Offset = "0x81188B0", VA = "0x188119EB0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x811A980", Offset = "0x8119380", VA = "0x18811A980")]
		public void Scrub(float FPIFKAOGCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x811A9E0", Offset = "0x81193E0", VA = "0x18811A9E0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x811A870", Offset = "0x8119270", VA = "0x18811A870")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x811A7F0", Offset = "0x81191F0", VA = "0x18811A7F0")]
		[IteratorStateMachine(typeof(DPBMAMLPGOL))]
		public IEnumerator<BHOPOIJKEJE> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8119EA0", Offset = "0x81188A0", VA = "0x188119EA0", Slot = "4")]
		private void LOMFEGOCBJH(bool FJOBDLEAALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
