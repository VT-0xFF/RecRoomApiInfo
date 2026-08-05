using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityEngine.AI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Vector3 m_StartPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private Vector3 m_EndPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float m_Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private int m_CostModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool m_Bidirectional;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool m_AutoUpdatePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private NavMeshLinkInstance m_LinkInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<NavMeshLink> s_Tracked;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4118D0", Offset = "0x410CD0", VA = "0x1804118D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x305C7C0", Offset = "0x305BBC0", VA = "0x18305C7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 startPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x439410", Offset = "0x438810", VA = "0x180439410")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x305C8C0", Offset = "0x305BCC0", VA = "0x18305C8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 endPoint
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5D5E70", Offset = "0x5D5270", VA = "0x1805D5E70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x305C880", Offset = "0x305BC80", VA = "0x18305C880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float width
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x41A920", Offset = "0x419D20", VA = "0x18041A920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x305C900", Offset = "0x305BD00", VA = "0x18305C900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int costModifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x40CC00", Offset = "0x40C000", VA = "0x18040CC00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x305C850", Offset = "0x305BC50", VA = "0x18305C850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool bidirectional
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CE0", Offset = "0x7E20E0", VA = "0x1807E2CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x305C820", Offset = "0x305BC20", VA = "0x18305C820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool autoUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7E2CD0", Offset = "0x7E20D0", VA = "0x1807E2CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x305C2F0", Offset = "0x305B6F0", VA = "0x18305C2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E70", Offset = "0x3C5270", VA = "0x1803C5E70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x305C7F0", Offset = "0x305BBF0", VA = "0x18305C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x305C150", Offset = "0x305B550", VA = "0x18305C150")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x305C0F0", Offset = "0x305B4F0", VA = "0x18305C0F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x305C0C0", Offset = "0x305B4C0", VA = "0x18305C0C0")]
		public void UpdateLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x305BE30", Offset = "0x305B230", VA = "0x18305BE30")]
		private static void AddTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x305C1D0", Offset = "0x305B5D0", VA = "0x18305C1D0")]
		private static void RemoveTracking(NavMeshLink link)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x305C2F0", Offset = "0x305B6F0", VA = "0x18305C2F0")]
		private void SetAutoUpdate(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x305BC10", Offset = "0x305B010", VA = "0x18305BC10")]
		private void AddLink()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x305BF80", Offset = "0x305B380", VA = "0x18305BF80")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x305C0C0", Offset = "0x305B4C0", VA = "0x18305C0C0")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x305C390", Offset = "0x305B790", VA = "0x18305C390")]
		private static void UpdateTrackedInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x305C6A0", Offset = "0x305BAA0", VA = "0x18305C6A0")]
		public NavMeshLink()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private bool m_OverrideArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private bool m_IgnoreFromBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly List<NavMeshModifier> s_NavMeshModifiers;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool overrideArea
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x4124C0", Offset = "0x4118C0", VA = "0x1804124C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x4124B0", Offset = "0x4118B0", VA = "0x1804124B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x443FD0", Offset = "0x4433D0", VA = "0x180443FD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x443FE0", Offset = "0x4433E0", VA = "0x180443FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ignoreFromBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x438DC0", Offset = "0x4381C0", VA = "0x180438DC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x438F90", Offset = "0x438390", VA = "0x180438F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static List<NavMeshModifier> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x305D020", Offset = "0x305C420", VA = "0x18305D020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x305CE40", Offset = "0x305C240", VA = "0x18305CE40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x305CDC0", Offset = "0x305C1C0", VA = "0x18305CDC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x305CD10", Offset = "0x305C110", VA = "0x18305CD10")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x305CF70", Offset = "0x305C370", VA = "0x18305CF70")]
		public NavMeshModifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private int m_Area;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private List<int> m_AffectedAgents;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x80DE70", Offset = "0x80D270", VA = "0x18080DE70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x80DEB0", Offset = "0x80D2B0", VA = "0x18080DEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x80D6E0", Offset = "0x80CAE0", VA = "0x18080D6E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x80DE90", Offset = "0x80D290", VA = "0x18080DE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public int area
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3B67F0", Offset = "0x3B5BF0", VA = "0x1803B67F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x45CAE0", Offset = "0x45BEE0", VA = "0x18045CAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static List<NavMeshModifierVolume> activeModifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x305CCB0", Offset = "0x305C0B0", VA = "0x18305CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x305CA60", Offset = "0x305BE60", VA = "0x18305CA60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x305C9E0", Offset = "0x305BDE0", VA = "0x18305C9E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x305C930", Offset = "0x305BD30", VA = "0x18305C930")]
		public bool AffectsAgentType(int agentTypeID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x305CB90", Offset = "0x305BF90", VA = "0x18305CB90")]
		public NavMeshModifierVolume()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum CollectObjects
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Volume,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Children
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[ExecuteAlways]
	[DefaultExecutionOrder(-102)]
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private int m_AgentTypeID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private CollectObjects m_CollectObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private Vector3 m_Size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private Vector3 m_Center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private LayerMask m_LayerMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private int m_DefaultArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private bool m_IgnoreNavMeshAgent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private bool m_IgnoreNavMeshObstacle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private bool m_OverrideTileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private int m_TileSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private bool m_OverrideVoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float m_VoxelSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private bool m_BuildHeightMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[FormerlySerializedAs("m_BakedNavMeshData")]
		private NavMeshData m_NavMeshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NavMeshDataInstance m_NavMeshDataInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Vector3 m_LastPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion m_LastRotation;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly List<NavMeshSurface> s_NavMeshSurfaces;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<GameObject, NavMeshBuildSource[]> objectsToNavMeshBuildSources;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public int agentTypeID
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4118D0", Offset = "0x410CD0", VA = "0x1804118D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x412420", Offset = "0x411820", VA = "0x180412420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CollectObjects collectObjects
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x443FD0", Offset = "0x4433D0", VA = "0x180443FD0")]
			get
			{
				return default(CollectObjects);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x443FE0", Offset = "0x4433E0", VA = "0x180443FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector3 size
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5D03B0", Offset = "0x5CF7B0", VA = "0x1805D03B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5D0340", Offset = "0x5CF740", VA = "0x1805D0340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector3 center
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9D33F0", Offset = "0x9D27F0", VA = "0x1809D33F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9D3500", Offset = "0x9D2900", VA = "0x1809D3500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LayerMask layerMask
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x40CC00", Offset = "0x40C000", VA = "0x18040CC00")]
			get
			{
				return default(LayerMask);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x528C30", Offset = "0x528030", VA = "0x180528C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NavMeshCollectGeometry useGeometry
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3CA9B0", Offset = "0x3C9DB0", VA = "0x1803CA9B0")]
			get
			{
				return default(NavMeshCollectGeometry);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x528D90", Offset = "0x528190", VA = "0x180528D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public int defaultArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3C5E70", Offset = "0x3C5270", VA = "0x1803C5E70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x491C20", Offset = "0x491020", VA = "0x180491C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ignoreNavMeshAgent
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7A5E90", Offset = "0x7A5290", VA = "0x1807A5E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A5EE0", Offset = "0x7A52E0", VA = "0x1807A5EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ignoreNavMeshObstacle
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xBD2CB0", Offset = "0xBD20B0", VA = "0x180BD2CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xBD2D50", Offset = "0xBD2150", VA = "0x180BD2D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool overrideTileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x100B470", Offset = "0x100A870", VA = "0x18100B470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x100B570", Offset = "0x100A970", VA = "0x18100B570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int tileSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x45FB60", Offset = "0x45EF60", VA = "0x18045FB60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x491C40", Offset = "0x491040", VA = "0x180491C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool overrideVoxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4D73A0", Offset = "0x4D67A0", VA = "0x1804D73A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4D7390", Offset = "0x4D6790", VA = "0x1804D7390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float voxelSize
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8354E0", Offset = "0x8348E0", VA = "0x1808354E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xDAC6F0", Offset = "0xDABAF0", VA = "0x180DAC6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool buildHeightMesh
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4AB130", Offset = "0x4AA530", VA = "0x1804AB130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4AA5E0", Offset = "0x4A99E0", VA = "0x1804AA5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NavMeshData navMeshData
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3BB390", Offset = "0x3BA790", VA = "0x1803BB390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x406490", Offset = "0x405890", VA = "0x180406490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static List<NavMeshSurface> activeSurfaces
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3060EC0", Offset = "0x30602C0", VA = "0x183060EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3060330", Offset = "0x305F730", VA = "0x183060330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x30601C0", Offset = "0x305F5C0", VA = "0x1830601C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x305D3A0", Offset = "0x305C7A0", VA = "0x18305D3A0")]
		public static void AddNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x30606D0", Offset = "0x305FAD0", VA = "0x1830606D0")]
		public static void RemoveNavMeshSource(GameObject gameObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x305EAB0", Offset = "0x305DEB0", VA = "0x18305EAB0")]
		public static void CollectNavMeshSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x305F5E0", Offset = "0x305E9E0", VA = "0x18305F5E0")]
		private static NavMeshBuildSource GetBuildSourceForCollider(Collider collider)
		{
			return default(NavMeshBuildSource);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x305FAE0", Offset = "0x305EEE0", VA = "0x18305FAE0")]
		private static NavMeshBuildSourceShape GetBuildSourceShapeForCollider(Collider collider)
		{
			return default(NavMeshBuildSourceShape);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x305D210", Offset = "0x305C610", VA = "0x18305D210")]
		public void AddData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x30606B0", Offset = "0x305FAB0", VA = "0x1830606B0")]
		public void RemoveData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x305F450", Offset = "0x305E850", VA = "0x18305F450")]
		public NavMeshBuildSettings GetBuildSettings()
		{
			return default(NavMeshBuildSettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x305DCD0", Offset = "0x305D0D0", VA = "0x18305DCD0")]
		public void BuildNavMesh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305FEF0", VA = "0x183060AF0")]
		public AsyncOperation UpdateNavMesh(NavMeshData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x305D140", Offset = "0x305C540", VA = "0x18305D140")]
		public void AddAsyncGeneratedNavMeshData(NavMeshData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3060510", Offset = "0x305F910", VA = "0x183060510")]
		private static void Register(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x30607A0", Offset = "0x305FBA0", VA = "0x1830607A0")]
		private static void Unregister(NavMeshSurface surface)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x30608C0", Offset = "0x305FCC0", VA = "0x1830608C0")]
		private static void UpdateActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x305D660", Offset = "0x305CA60", VA = "0x18305D660")]
		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x305EC40", Offset = "0x305E040", VA = "0x18305EC40")]
		private List<NavMeshBuildSource> CollectSources()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x305D080", Offset = "0x305C480", VA = "0x18305D080")]
		private static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x305FBF0", Offset = "0x305EFF0", VA = "0x18305FBF0")]
		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x305E020", Offset = "0x305D420", VA = "0x18305E020")]
		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3060080", Offset = "0x305F480", VA = "0x183060080")]
		private bool HasTransformChanged()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3060990", Offset = "0x305FD90", VA = "0x183060990")]
		private void UpdateDataIfTransformChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3060D90", Offset = "0x3060190", VA = "0x183060D90")]
		public NavMeshSurface()
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
