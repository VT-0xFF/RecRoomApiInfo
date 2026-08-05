using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom.Core.Creation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public global::BIKJMNNNOIL<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NAGOODHDFBO CCKFGJGONAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] OAGACOBKFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] EBGKDPFGJAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<NAGOODHDFBO> AIMCCPPKOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6463780", Offset = "0x6462180", VA = "0x186463780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6463820", Offset = "0x6462220", VA = "0x186463820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64633C0", Offset = "0x6461DC0", VA = "0x1864633C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6463480", Offset = "0x6461E80", VA = "0x186463480")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6463530", Offset = "0x6461F30", VA = "0x186463530")]
		public void SetIConfigurable(NAGOODHDFBO HMKLLANAJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64633D0", Offset = "0x6461DD0", VA = "0x1864633D0")]
		public void ChangeCollidersAndRenderers(Collider[] NCDEIFMKDAN, Renderer[] CGPMCPFLDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6463670", Offset = "0x6462070", VA = "0x186463670")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64634E0", Offset = "0x6461EE0", VA = "0x1864634E0")]
		public void RunConfigurationSpecialActions(NAGOODHDFBO MMEJLMPKPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6463700", Offset = "0x6462100", VA = "0x186463700")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MANHJLPJDJH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AFBDMELNPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PBBMNAAFCOC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AddIsAnimated(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RemoveIsAnimated(object DEGCIHEAIBD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FJMNPNCENCP
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece NBEPNGMAJAE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece NBEPNGMAJAE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider FGPOCJNLNLF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MKPEKMMFHKC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid HDNFGGCIKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string FHGALKFAAON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 NJJBCKOHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion KKEIEPMJOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DEOPFAEIOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LMOFGOGBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 BBPLHKICOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 GAIEJJBGHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JDLKAHBBBON
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool EDCAEIPJCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NAGOODHDFBO CCKFGJGONAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ILNBLBGFPFL PDNEODMNHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action KFJGMGDBHJA;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CanUpdateDeformation(Vector3 MNNBNKFCFHJ, float DFLNFAAFCOF, float KMLJNGOGBFI);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void UpdateDeformation(Vector3 MNNBNKFCFHJ, float DFLNFAAFCOF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CanBeRaycasted(Collider FGPOCJNLNLF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BEIHNANGMNF
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OFDGOLFFLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool FDHDFHEMBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 IDFFFFIMCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Vector3 JEGJHKBFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool IHMMDCDHBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CJFCFEJAIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LNNFDJPKIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IHDEFNKOJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool OOMFLPIEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ELMDPLGAEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnMoveStart();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnDeformed(Vector3 PDKMIJPIGDP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnMoveFinished();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverStart(POMBEPLHAFH FHMEFGINBJI, Collider NMALHELEGAH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OnHovering(POMBEPLHAFH FHMEFGINBJI, Collider NMALHELEGAH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OnHoverFinished(POMBEPLHAFH FHMEFGINBJI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Translate(Vector3 AEEFFKHBKNB);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Rotate(Quaternion DPIOGGOKNFD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool Scale(float EGAHANLMNHJ);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FHCIJIBPMAC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBHMEMEIBCG(in Vector3 DKLFBNALGBC, in Vector3 PANBGKEJNBF, ref Vector3 LLAEOCBHPAM, ref Vector3 PIELFIAEDGN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GCPDIMKLAGG
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AJDDIJFCKOM DIGIJMDCCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOJNBEDIFCE
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool CCFHHOJFIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	GMEOHAIONFG IDFFAENGCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> CIDDEPIFHNB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int EJDIPHAOEMI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLFLMPPMGID GetCulprit(HBNCEAJKNOG COIMGJNANFP);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HLBFPNKBEAM
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<DPCCDCLLPEG.GODABDHOLBB> CJMFKIOIEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(DPCCDCLLPEG.GODABDHOLBB MOAEAOCMBKB);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(DPCCDCLLPEG.GODABDHOLBB MOAEAOCMBKB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MAPACFCIBOK
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanModifyProperty(string IJEJFFCLBDM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NLEFAELMBKA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int OACDACIAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(ECAGGLGKIMN? KIJDDEBDFKL);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(BDFOGDLNFAP? GIKLJDACLBE);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HBNCEAJKNOG CanBeSelected();

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CanBeSelected(out HBNCEAJKNOG OAFMFLFMLNI, out LLFLMPPMGID PGHKEABJLJP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PKEBHMGBCBF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DMCFLCPEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CostInfo EHMILIGELPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool DKHOLPLCJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DLCJPFAPFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool IAEGNKKAFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool HHFGKDJHFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NKGCIBIPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool BJDODEKNOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool EALMPIMDCIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> NJJDFMMDDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BoxCollider PGBJIAPCBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool ENNLGAPGEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JOCEDMGGPHH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBNCEAJKNOG CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 OAALNDIAAOB, out Quaternion HOOCPOKGFMC, out float EIMFGGDMPEH, out Vector3 FLLODDHPGFN);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? OAALNDIAAOB, Quaternion? HOOCPOKGFMC, float? EIMFGGDMPEH, Vector3? FLLODDHPGFN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OPBLANFMNAF
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	object LNGAGLGKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Type EMBBINHFEFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Guid PIDLNIMLCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NAGOODHDFBO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IReadOnlyList<LNNCJCCIIKP> KLOOIOPHEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string FHGALKFAAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string GMFGMPIJCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string> GCEJGDGBHBG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<NAGOODHDFBO> FCHJBLFBKDM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<LBLMPABBGHG, KLKFJBOGOBF> LFIDHPFEIAC;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PFECOILBKJC;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AEKGLMLHMHA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HDODMCLAAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DPCCDCLLPEG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate KCBOOHFFPAG GODABDHOLBB();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<GODABDHOLBB> KCKOGMMKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<GODABDHOLBB> EDHMMKJHNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IEnumerable<GODABDHOLBB> GEDFHADKDJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64638C0", Offset = "0x64622C0", VA = "0x1864638C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6463930", Offset = "0x6462330", VA = "0x186463930")]
	public void CPLOAHMOJFD(GODABDHOLBB MOAEAOCMBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6463AE0", Offset = "0x64624E0", VA = "0x186463AE0")]
	public bool OLCIACFECIH(GODABDHOLBB MOAEAOCMBKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KCBOOHFFPAG
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum PKGLCHDGKJK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ILNBLBGFPFL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int LNJABLLNHHF = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long GCPADHFNKAL = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private global::JABCBBFNIEP<Guid, ObscuredLong, ObscuredInt, ObscuredBool> GFHDDBBFKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::JDBKCBJMLGI<ObscuredBool, ObscuredInt, ObscuredInt> HAMDFFIGEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun IGMAFPJOAIE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid JJGHHEMMDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6464670", Offset = "0x6463070", VA = "0x186464670")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public long KNLBDBHPGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64643D0", Offset = "0x6462DD0", VA = "0x1864643D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JCGIMGNNKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6464330", Offset = "0x6462D30", VA = "0x186464330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FOAGGBCOACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6464480", Offset = "0x6462E80", VA = "0x186464480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NJCBGGBKDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64645D0", Offset = "0x6462FD0", VA = "0x1864645D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int CEPJMACAIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6463FA0", Offset = "0x64629A0", VA = "0x186463FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int LMEMIHGNOML
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6463F00", Offset = "0x6462900", VA = "0x186463F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OLDGAEJOLNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6464040", Offset = "0x6462A40", VA = "0x186464040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6464B40", Offset = "0x6463540", VA = "0x186464B40")]
	public ILNBLBGFPFL(MonoBehaviourPun DGPKIGACMNE, string IHPCMLBOENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6464810", Offset = "0x6463210", VA = "0x186464810")]
	public ILNBLBGFPFL(MonoBehaviourPun DGPKIGACMNE, string IHPCMLBOENO, Guid KNHGHECKNHP, long DMAEEAENEBG, int KDBADNCFCNL, bool LFDOLOFGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6463C20", Offset = "0x6462620", VA = "0x186463C20")]
	public void AJMIOEHODNH(LLFLMPPMGID GOAMCCJIGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6463DE0", Offset = "0x64627E0", VA = "0x186463DE0")]
	public void FPMNIAKKMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6464080", Offset = "0x6462A80", VA = "0x186464080")]
	public void JGKFDHOAMGH(Guid EBIFLDKAEBC, long DMAEEAENEBG, int KDBADNCFCNL, bool LFDOLOFGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6464260", Offset = "0x6462C60", VA = "0x186464260")]
	public void JGKFDHOAMGH(ILNBLBGFPFL DFHJPOKNFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64647A0", Offset = "0x64631A0", VA = "0x1864647A0")]
	public void PKKOIGJMODB(EJBGBEKDBLL NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6464520", Offset = "0x6462F20", VA = "0x186464520")]
	public void NBIELFFAOPP(EJBGBEKDBLL NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x64646E0", Offset = "0x64630E0", VA = "0x1864646E0")]
	public static EJBGBEKDBLL OHGCKCBLLPK(Guid KNHGHECKNHP, long DMAEEAENEBG, int BLIPGPPNIID, bool LFDOLOFGDPB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6464F40", Offset = "0x6463940", VA = "0x186464F40")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6464BF0", Offset = "0x64635F0", VA = "0x186464BF0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
