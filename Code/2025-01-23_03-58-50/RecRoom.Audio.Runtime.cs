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
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NLDNJEMFMAO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D963A0", Offset = "0x6D94BA0", VA = "0x186D963A0")]
	public static void HEELPJPLJKD(this AudioSource MDDJJNLPAJB, AudioRolloff AOEFAHCPOHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NDLJNBGAOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D96340", Offset = "0x6D94B40", VA = "0x186D96340")]
	public static float PLBFGNJHPBE(float LDNOMLAKOCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D96300", Offset = "0x6D94B00", VA = "0x186D96300")]
	public static float GDIDEEBOFNN(float FPLJLGPLHBC)
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
		[Cpp2IlInjected.Address(RVA = "0x6D957F0", Offset = "0x6D93FF0", VA = "0x186D957F0")]
		public float KIFGGPFPPKL(float FLFOMIFMFBD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D95AC0", Offset = "0x6D942C0", VA = "0x186D95AC0")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JPDFBMOBBEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IHKFKAKLOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, GMEKKAAMOLN> CLAGAEMKADI();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Dictionary<string, GMEKKAAMOLN> GKINMKDHANL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IList<(string, NKOCPABNFHO)> NILMANGILPM();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKOCPABNFHO EOMALEDGNGO();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AudioMixerGroup DANODLDDKFM(GCIPOACPEKA NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AudioMixerGroup IIALMOIHIFE(NKOCPABNFHO FDNKHBDAHBI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource CMIHKCDNPJL(RecRoomAudioClip ILBFELOMAGC, Transform DKODOCOJJMP, [Optional] AudioRolloff DDNMOJBOGAA, [Optional] Action<SFXAudioSource> LOKJAPFADJJ, [Optional] NKOCPABNFHO? NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GAHALIAPBLJ(SFXAudioSource OGOFGCOLFAE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource EKNOPBGCMIC(RecRoomAudioClip[] HCFPMOBOBNB, bool JGALJKBHPPE = false, float OCBACMAPJEB = 1f, [Optional] Action<SFXAudioSource> LOKJAPFADJJ, [Optional] NKOCPABNFHO? NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource BIFKGGHOOEN(RecRoomAudioClip[] HCFPMOBOBNB, Transform DKODOCOJJMP, [Optional] AudioRolloff DDNMOJBOGAA, bool JGALJKBHPPE = false, [Optional] Action<SFXAudioSource> LOKJAPFADJJ, [Optional] NKOCPABNFHO? NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource BCMCPPMKPJA(RecRoomAudioClip KCGLELEJHEO, Vector3 KDFMPBNDHDB, bool HNIDFDBMGCM, [Optional] AudioRolloff DDNMOJBOGAA, [Optional] Action<SFXAudioSource> LOKJAPFADJJ, [Optional] NKOCPABNFHO? NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "11")]
	SFXAudioSource OBONHFCFPCL(RecRoomAudioClip JNKMKLCMPAJ, [Optional] Action<SFXAudioSource> LOKJAPFADJJ, [Optional] NKOCPABNFHO? NIEDIBKMFCK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EBBFPAKHIHA HGDHKPIOMAP(SFXAudioSource OGOFGCOLFAE, float PKAGGLJKIOF, float IGEHIFGNOPE);
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
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6D96570", Offset = "0x6D94D70", VA = "0x186D96570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D965C0", Offset = "0x6D94DC0", VA = "0x186D965C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D96520", Offset = "0x6D94D20", VA = "0x186D96520")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D96530", Offset = "0x6D94D30", VA = "0x186D96530")]
		public RecRoomAudioClip(AudioClip JNKMKLCMPAJ)
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
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D96460", Offset = "0x6D94C60", VA = "0x186D96460")]
		public bool HNBGIHIGKEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9535A0", Offset = "0x951DA0", VA = "0x1809535A0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AddressableSFXTrackBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		protected SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		protected SFXTrack.LHDAFFAIAMJ trackType;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D957C0", Offset = "0x6D93FC0", VA = "0x186D957C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public abstract float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public SFXTrack.LHDAFFAIAMJ TrackType
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
			get
			{
				return default(SFXTrack.LHDAFFAIAMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6D95520", Offset = "0x6D93D20", VA = "0x186D95520")]
		protected void IECCFFPELJK(string CANHCNAPBAJ, SFXTrack.LHDAFFAIAMJ GEEBGKDELCG, Guid PLMJELCKKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6D956B0", Offset = "0x6D93EB0", VA = "0x186D956B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D955D0", Offset = "0x6D93DD0", VA = "0x186D955D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D95700", Offset = "0x6D93F00", VA = "0x186D95700")]
		protected AddressableSFXTrackBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RuntimeAddressableSFXTrack : AddressableSFXTrackBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private AssetReference assetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private float clipLengthSeconds;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public AssetReference AssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override float ClipLengthSeconds
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x924D00", Offset = "0x923500", VA = "0x180924D00", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D96650", Offset = "0x6D94E50", VA = "0x186D96650")]
		public void IECCFFPELJK(string CANHCNAPBAJ, SFXTrack.LHDAFFAIAMJ GEEBGKDELCG, Guid PLMJELCKKDA, float LFNLHGNLENK, AssetReference NCNKGBHEOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D95700", Offset = "0x6D93F00", VA = "0x186D95700")]
		public RuntimeAddressableSFXTrack()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SFXTracklistRuntimeConfig : SingletonScriptableObject<SFXTracklistRuntimeConfig>
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DIINKHKNHFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int i;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public DIINKHKNHFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D95BB0", Offset = "0x6D943B0", VA = "0x186D95BB0")]
			internal IPKLCOLPGOB<Guid>.PIAEMMINOIK KADKIPCBHMB(RuntimeAddressableSFXTrack track)
			{
				return default(IPKLCOLPGOB<Guid>.PIAEMMINOIK);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IPKLCOLPGOB<Guid> guidMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private List<RuntimeAddressableSFXTrack> trackList;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static SFXTracklistRuntimeConfig RuntimeConfigAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D983B0", Offset = "0x6D96BB0", VA = "0x186D983B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public IPKLCOLPGOB<Guid> GuidMap
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D98220", Offset = "0x6D96A20", VA = "0x186D98220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<RuntimeAddressableSFXTrack> TrackList
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6D97EB0", Offset = "0x6D966B0", VA = "0x186D97EB0")]
		public MGNFCCKNAGM<AudioClip> ILDBCLALFMK(Guid BPDGFCJKDGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D97E10", Offset = "0x6D96610", VA = "0x186D97E10")]
		private MGNFCCKNAGM<AudioClip> ILDBCLALFMK(AssetReference BOHGMODCJLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6D98180", Offset = "0x6D96980", VA = "0x186D98180")]
		public SFXTracklistRuntimeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXAudioSource : MonoBehaviour, KIIHCDDLAJD.GIIFIFMBHOH
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct BIOJMNHPGPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public float? BJJCIJNHEGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public float? EDBNADLCPCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Vector3 HEGKMEGMPKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Transform EKIGPNEANKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AudioRolloff CLCJBOIEJNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float FNKDEKNOMJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public float COMNPOMNJLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public GCIPOACPEKA? POAMNLFMAMB;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public float NIBLAANFKAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x6D95AE0", Offset = "0x6D942E0", VA = "0x186D95AE0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public GCIPOACPEKA OJGMMHPICCN
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x6D95B60", Offset = "0x6D94360", VA = "0x186D95B60")]
				get
				{
					return default(GCIPOACPEKA);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct KIFECPIAKFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public BIOJMNHPGPD playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6D95C10", Offset = "0x6D94410", VA = "0x186D95C10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D961D0", Offset = "0x6D949D0", VA = "0x186D961D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LELBNHOOEOA : IEnumerator<IJKEOMMDACC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private IJKEOMMDACC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private IJKEOMMDACC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
			[DebuggerHidden]
			public LELBNHOOEOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6D96230", Offset = "0x6D94A30", VA = "0x186D96230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D962B0", Offset = "0x6D94AB0", VA = "0x186D962B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Action<SFXAudioSource> BLAHEPJMGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DGGJLAPANLP NHKAAIGEFPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BLOHICJFBII OMAEIKKENKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JPDFBMOBBEB HKOOMHAKMNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float ACKKMMAJNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float EOFOLNPOPLE;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string FICCAFGFHMA = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Transform EKIGPNEANKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ONAIMHPDBIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D97CF0", Offset = "0x6D964F0", VA = "0x186D97CF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PILJBIFCLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D97DD0", Offset = "0x6D965D0", VA = "0x186D97DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HNMBPLEIMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D97DB0", Offset = "0x6D965B0", VA = "0x186D97DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float BJJCIJNHEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D97DF0", Offset = "0x6D965F0", VA = "0x186D97DF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float NCOFCCHNEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D97D10", Offset = "0x6D96510", VA = "0x186D97D10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6D96720", Offset = "0x6D94F20", VA = "0x186D96720")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D96F70", Offset = "0x6D95770", VA = "0x186D96F70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D97C30", Offset = "0x6D96430", VA = "0x186D97C30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D97C10", Offset = "0x6D96410", VA = "0x186D97C10")]
		public void UpdateVolume(float GLIHLJNKBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D97A00", Offset = "0x6D96200", VA = "0x186D97A00")]
		public void UpdatePitch(float BEFOBPBCJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D97960", Offset = "0x6D96160", VA = "0x186D97960")]
		public void UpdateDopplerLevel(float IAGFHMEDPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D97B70", Offset = "0x6D96370", VA = "0x186D97B70")]
		public void UpdateSpatialBlend(float EGGKNGLFONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6D97890", Offset = "0x6D96090", VA = "0x186D97890")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D97250", Offset = "0x6D95A50", VA = "0x186D97250")]
		public void Play(AudioClip JNKMKLCMPAJ, float GLIHLJNKBGG, Vector3 KDFMPBNDHDB, float ACJMPCDIDCM, float FCJGDLMOOBG, AudioRolloff AOEFAHCPOHM, [Optional] Action<SFXAudioSource> MJKDHIPDLIH, [Optional] NKOCPABNFHO? NIEDIBKMFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D97100", Offset = "0x6D95900", VA = "0x186D97100")]
		[AsyncStateMachine(typeof(KIFECPIAKFP))]
		public Task PlayAsync(AudioClip JNKMKLCMPAJ, BIOJMNHPGPD OAIPOOCMKAF, CancellationToken ALKEMFHOMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D96810", Offset = "0x6D95010", VA = "0x186D96810")]
		private void FADHBNKNADM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D96F10", Offset = "0x6D95710", VA = "0x186D96F10")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D978C0", Offset = "0x6D960C0", VA = "0x186D978C0")]
		public void Scrub(float MHAEBFLONHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D97920", Offset = "0x6D96120", VA = "0x186D97920")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D977C0", Offset = "0x6D95FC0", VA = "0x186D977C0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D97740", Offset = "0x6D95F40", VA = "0x186D97740")]
		[IteratorStateMachine(typeof(LELBNHOOEOA))]
		public IEnumerator<IJKEOMMDACC> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D96F60", Offset = "0x6D95760", VA = "0x186D96F60", Slot = "4")]
		private void NAADIDPLLLJ(bool PBBJGOAILGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
