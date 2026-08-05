using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x784CE80", Offset = "0x784C280", VA = "0x18784CE80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KCOHLBGGNDN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F41440", Offset = "0x1F40840", VA = "0x181F41440")]
	public KCOHLBGGNDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LKHFDMEDDEH, ELOKANIMHDL, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBD44B0", Offset = "0xBD38B0", VA = "0x180BD44B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FJJIBEAAGGP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAFB4C0", Offset = "0xAFA8C0", VA = "0x180AFB4C0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x784E090", Offset = "0x784D490", VA = "0x18784E090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x784E050", Offset = "0x784D450", VA = "0x18784E050")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x784E0D0", Offset = "0x784D4D0", VA = "0x18784E0D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x784E280", Offset = "0x784D680", VA = "0x18784E280")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x784E1F0", Offset = "0x784D5F0", VA = "0x18784E1F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE322F0", Offset = "0xE316F0", VA = "0x180E322F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC85350", Offset = "0xC84750", VA = "0x180C85350")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x784E010", Offset = "0x784D410", VA = "0x18784E010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x784E160", Offset = "0x784D560", VA = "0x18784E160")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x784DAB0", Offset = "0x784CEB0", VA = "0x18784DAB0")]
	public void CopyBounds(SavedExtents KNCKFHOKGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x784DF60", Offset = "0x784D360", VA = "0x18784DF60")]
	public void SetLocalSpaceBounds(Bounds PDOHOPOOJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x12FCDC0", Offset = "0x12FC1C0", VA = "0x1812FCDC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x784DF50", Offset = "0x784D350", VA = "0x18784DF50")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x784DBA0", Offset = "0x784CFA0", VA = "0x18784DBA0")]
	private void OJLOLFCDNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x784DD50", Offset = "0x784D150", VA = "0x18784DD50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x784D440", Offset = "0x784C840", VA = "0x18784D440")]
	public static void CalculateLocalBoundsFor(GameObject GIIGFIAPGGB, [Out] Bounds PDOHOPOOJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x784DAE0", Offset = "0x784CEE0", VA = "0x18784DAE0")]
	private static void EBNIJNOKPBG(Bounds IAJJOLNCJOI, Color NOBKOCLLFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x784DF80", Offset = "0x784D380", VA = "0x18784DF80")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x993250", Offset = "0x992650", VA = "0x180993250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x176BF00", Offset = "0x176B300", VA = "0x18176BF00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x552D430", Offset = "0x552C830", VA = "0x18552D430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public virtual void FDEMLEMBLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x552CFA0", Offset = "0x552C3A0", VA = "0x18552CFA0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x552BB70", Offset = "0x552AF70", VA = "0x18552BB70", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x552D350", Offset = "0x552C750", VA = "0x18552D350")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NFGICKHLCDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public NFGICKHLCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50C1690", Offset = "0x50C0A90", VA = "0x1850C1690")]
		internal int OOFNDENFDCA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42EFE90", Offset = "0x42EF290", VA = "0x1842EFE90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x42EFEF0", Offset = "0x42EF2F0", VA = "0x1842EFEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x42EFD70", Offset = "0x42EF170", VA = "0x1842EFD70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DJBLFBEBKGO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42EFE30", Offset = "0x42EF230", VA = "0x1842EFE30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x42EFC20", Offset = "0x42EF020", VA = "0x1842EFC20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x42EF8C0", Offset = "0x42EECC0", VA = "0x1842EF8C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x42EEC80", Offset = "0x42EE080", VA = "0x1842EEC80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x42EEC20", Offset = "0x42EE020", VA = "0x1842EEC20", Slot = "14")]
	protected virtual string LPHMDCIGNBF(TKeyVal DPDEDCODDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x42EEAF0", Offset = "0x42EDEF0", VA = "0x1842EEAF0", Slot = "4")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x42EFAA0", Offset = "0x42EEEA0", VA = "0x1842EFAA0", Slot = "5")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x42EEB50", Offset = "0x42EDF50", VA = "0x1842EEB50", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x42EEB50", Offset = "0x42EDF50", VA = "0x1842EEB50", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x42EFB00", Offset = "0x42EEF00", VA = "0x1842EFB00")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x423D1B0", Offset = "0x423C5B0", VA = "0x18423D1B0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[KCOHLBGGNDN]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x552EE20", Offset = "0x552E220", VA = "0x18552EE20")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x552E660", Offset = "0x552DA60", VA = "0x18552E660", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x552DC10", Offset = "0x552D010", VA = "0x18552DC10", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HBJFAKOLEKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JBKJCAGJBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float LHAHEJJDJJP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int HGJKHNPMCNL = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FLMLCHPGFMG = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly JBKJCAGJBMA[] LLPLHOOOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int MPFDDBGHHCF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float GMEBDPLAFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB725C0", Offset = "0xB719C0", VA = "0x180B725C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xBBE420", Offset = "0xBBD820", VA = "0x180BBE420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T FHLINHJNANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48C9260", Offset = "0x48C8660", VA = "0x1848C9260")]
	protected HBJFAKOLEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x48C92A0", Offset = "0x48C86A0", VA = "0x1848C92A0")]
	protected HBJFAKOLEKH(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x48C9150", Offset = "0x48C8550", VA = "0x1848C9150")]
	public void JJBKLNLGAIJ(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NCNJNAKOCKM(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JNMGJCLIHOD(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x48C8FC0", Offset = "0x48C83C0", VA = "0x1848C8FC0")]
	public void CJEMNCEDADJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BKJKMEGFBDN : HBJFAKOLEKH<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x78490D0", Offset = "0x78484D0", VA = "0x1878490D0", Slot = "4")]
	public override bool NCNJNAKOCKM(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] Vector3 FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7848F90", Offset = "0x7848390", VA = "0x187848F90", Slot = "5")]
	public override bool JNMGJCLIHOD(float AAHABAEBMKI, float JJDOOOBNCBG, [Out] Vector3 FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7849230", Offset = "0x7848630", VA = "0x187849230")]
	public BKJKMEGFBDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OCPHFAFGDLD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x37F09D0", Offset = "0x37EFDD0", VA = "0x1837F09D0")]
	public static FFBPAJLKGII<T1, T2> GNHEPACBJCH<T1, T2>(T1 CEPEJICMGPN, T2 PJFDPDEPNKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x37F0A70", Offset = "0x37EFE70", VA = "0x1837F0A70")]
	public static FHPLGJCPPKH<T1, T2, T3> GNHEPACBJCH<T1, T2, T3>(T1 CEPEJICMGPN, T2 PJFDPDEPNKI, T3 MMPFIAOEEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x50A19D0", Offset = "0x50A0DD0", VA = "0x1850A19D0")]
	internal static int LPMAGMDFHMP(int CAPDDMICJHD, int ENEMLCKKGOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A91410", Offset = "0x6A90810", VA = "0x186A91410")]
	internal static int LPMAGMDFHMP(int CAPDDMICJHD, int ENEMLCKKGOC, int DJNCHHMNCJM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FFBPAJLKGII<T1, T2> : IComparable<FFBPAJLKGII<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 CMCIHGKDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 PIGNFBLMIFK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4708DD0", Offset = "0x47081D0", VA = "0x184708DD0")]
	public FFBPAJLKGII(T1 CEPEJICMGPN, T2 PJFDPDEPNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47074D0", Offset = "0x47068D0", VA = "0x1847074D0", Slot = "4")]
	public int CompareTo(FFBPAJLKGII<T1, T2> KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4707D50", Offset = "0x4707150", VA = "0x184707D50", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4708030", Offset = "0x4707430", VA = "0x184708030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4708610", Offset = "0x4707A10", VA = "0x184708610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FHPLGJCPPKH<T1, T2, T3> : IComparable<FHPLGJCPPKH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 CMCIHGKDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 PIGNFBLMIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 PIANNFJNJGP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4742290", Offset = "0x4741690", VA = "0x184742290")]
	public FHPLGJCPPKH(T1 CEPEJICMGPN, T2 PJFDPDEPNKI, T3 MMPFIAOEEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4741A80", Offset = "0x4740E80", VA = "0x184741A80", Slot = "4")]
	public int CompareTo(FHPLGJCPPKH<T1, T2, T3> KNCKFHOKGJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4741CF0", Offset = "0x47410F0", VA = "0x184741CF0", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4741F30", Offset = "0x4741330", VA = "0x184741F30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4741FD0", Offset = "0x47413D0", VA = "0x184741FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve MNCLLABCAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T JMAAAPLCODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE66620", Offset = "0xE65A20", VA = "0x180E66620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T DLLCDPIEFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB4B2C0", Offset = "0xB4A6C0", VA = "0x180B4B2C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A20190", Offset = "0x2A1F590", VA = "0x182A20190")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A200E0", Offset = "0x2A1F4E0", VA = "0x182A200E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float CLFKKIOCMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB45BB0", Offset = "0xB44FB0", VA = "0x180B45BB0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57CC1C0", Offset = "0x57CB5C0", VA = "0x1857CC1C0")]
	public T POKGMNHINPB(float OOLNPDLPIEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57CBFA0", Offset = "0x57CB3A0", VA = "0x1857CBFA0")]
	public T JKGLJIOALDN(float OOLNPDLPIEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LEPHLCNAIOB(T BICHNBDCKLH, T CKCKMBIGMMF, float OOLNPDLPIEB);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x784A0F0", Offset = "0x78494F0", VA = "0x18784A0F0", Slot = "4")]
	protected override float LEPHLCNAIOB(float BICHNBDCKLH, float CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x784A130", Offset = "0x7849530", VA = "0x18784A130")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x15DE520", Offset = "0x15DD920", VA = "0x1815DE520", Slot = "4")]
	protected override Vector3 LEPHLCNAIOB(Vector3 BICHNBDCKLH, Vector3 CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x784F0A0", Offset = "0x784E4A0", VA = "0x18784F0A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7849370", Offset = "0x7848770", VA = "0x187849370", Slot = "4")]
	protected override Color LEPHLCNAIOB(Color BICHNBDCKLH, Color CKCKMBIGMMF, float OOLNPDLPIEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7849430", Offset = "0x7848830", VA = "0x187849430")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HBEBANAGJFM : PJEGKALNPFE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x784B250", Offset = "0x784A650", VA = "0x18784B250")]
	public HBEBANAGJFM(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x784B1E0", Offset = "0x784A5E0", VA = "0x18784B1E0", Slot = "6")]
	protected override uint NODBEKNMJCK(uint FJJIBEAAGGP, string FFOEEMKIKJO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LGEKACGMFJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public LGEKACGMFJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OBJHIMBOAOB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CLKDLLHEAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int HALBMBHIMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HFFLKMOEJFN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x47532D0", Offset = "0x47526D0", VA = "0x1847532D0")]
	private OBJHIMBOAOB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HAGBHIMNECF, int PEAMCKLLHAK, int KFIDAOBPDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51D7B80", Offset = "0x51D6F80", VA = "0x1851D7B80")]
	public static OBJHIMBOAOB<T> HBLBJMFGHFK()
	{
		return default(OBJHIMBOAOB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51D7C80", Offset = "0x51D7080", VA = "0x1851D7C80")]
	public (int, int, Task<T>) JBEILPHNOEM(int GIBMIJMGIIO, [Optional] CancellationToken LMNHDKIFBOH, double PCFGHPNONAI = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51D9AC0", Offset = "0x51D8EC0", VA = "0x1851D9AC0")]
	public void MKOCGHEOGGO(int GIBMIJMGIIO, int KFIDAOBPDOI, [In] T HBALBIOOGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KLOBCFPPNGL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x784B900", Offset = "0x784AD00", VA = "0x18784B900")]
	public static OBJHIMBOAOB<LPCAMBCOBBH> HBLBJMFGHFK()
	{
		return default(OBJHIMBOAOB<LPCAMBCOBBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x784B950", Offset = "0x784AD50", VA = "0x18784B950")]
	public static void MKOCGHEOGGO([In] this OBJHIMBOAOB<LPCAMBCOBBH> JOCJBPPJMJJ, int GIBMIJMGIIO, int KFIDAOBPDOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class CCEPICLLJMB<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> MMAENBAOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> ILFDPFBIANN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B50", Offset = "0x3E97F50", VA = "0x183E98B50", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JPBJOHHNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4735CC0", Offset = "0x47350C0", VA = "0x184735CC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> BDMOHMNBJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x42DF8B0", Offset = "0x42DECB0", VA = "0x1842DF8B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6306CA0", Offset = "0x63060A0", VA = "0x186306CA0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6306D40", Offset = "0x6306140", VA = "0x186306D40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6306120", Offset = "0x6305520", VA = "0x186306120")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6306180", Offset = "0x6305580", VA = "0x186306180", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6306A80", Offset = "0x6305E80", VA = "0x186306A80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6305F60", Offset = "0x6305360", VA = "0x186305F60", Slot = "9")]
	public void Add(TKey DJBLFBEBKGO, TVal FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6305F10", Offset = "0x6305310", VA = "0x186305F10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6306220", Offset = "0x6305620", VA = "0x186306220", Slot = "8")]
	public bool ContainsKey(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63062B0", Offset = "0x63056B0", VA = "0x1863062B0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x63069C0", Offset = "0x6305DC0", VA = "0x1863069C0", Slot = "10")]
	public bool Remove(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6306A40", Offset = "0x6305E40", VA = "0x186306A40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6306B20", Offset = "0x6305F20", VA = "0x186306B20", Slot = "11")]
	public bool TryGetValue(TKey DJBLFBEBKGO, [Out] TVal FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6306370", Offset = "0x6305770", VA = "0x186306370", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x63062F0", Offset = "0x63056F0", VA = "0x1863062F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6306060", Offset = "0x6305460", VA = "0x186306060")]
	public bool BGPIDOLLEKE(TVal DJBLFBEBKGO, [Out] TKey FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6306410", Offset = "0x6305810", VA = "0x186306410")]
	private void HBAAKKDANCD(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63066A0", Offset = "0x6305AA0", VA = "0x1863066A0")]
	private void IEAMEODBOFE(TKey DJBLFBEBKGO, TVal PCJCDFNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6306790", Offset = "0x6305B90", VA = "0x186306790")]
	private bool KJOCGPOLNFE(TKey DJBLFBEBKGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6306B80", Offset = "0x6305F80", VA = "0x186306B80")]
	public CCEPICLLJMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class DCBIKFPCNEG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DCBIKFPCNEG<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x4348AD0", Offset = "0x4347ED0", VA = "0x184348AD0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x434AA60", Offset = "0x4349E60", VA = "0x18434AA60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x434C120", Offset = "0x434B520", VA = "0x18434C120")]
		public Enumerator(DCBIKFPCNEG<T> DAMDACDIHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4348EA0", Offset = "0x43482A0", VA = "0x184348EA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x434A1F0", Offset = "0x43495F0", VA = "0x18434A1F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4348D30", Offset = "0x4348130", VA = "0x184348D30")]
		private void MJFHKHIAHDO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] HHOLFJLOEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int GNPKFMEIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HGILLAMPJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int IOFNCNFBMGK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6656F50", Offset = "0x6656350", VA = "0x186656F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6656B80", Offset = "0x6655F80", VA = "0x186656B80")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66578C0", Offset = "0x6656CC0", VA = "0x1866578C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6658CA0", Offset = "0x66580A0", VA = "0x186658CA0")]
	public DCBIKFPCNEG(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6658150", Offset = "0x6657550", VA = "0x186658150")]
	public void JJBKLNLGAIJ(T OOLNPDLPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6656E20", Offset = "0x6656220", VA = "0x186656E20")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6657BB0", Offset = "0x6656FB0", VA = "0x186657BB0")]
	public void JCBOCJJKOIJ(int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6657270", Offset = "0x6656670", VA = "0x186657270")]
	public void DHDJJANPOHF(T[] LLPLHOOOAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6656E40", Offset = "0x6656240", VA = "0x186656E40")]
	public Enumerator DBEEDGEHMMA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66589C0", Offset = "0x6657DC0", VA = "0x1866589C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x66589C0", Offset = "0x6657DC0", VA = "0x1866589C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6658730", Offset = "0x6657B30", VA = "0x186658730")]
	private int LAJNFGCLFAP(int CJFNAFNJJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6658990", Offset = "0x6657D90", VA = "0x186658990")]
	private int OEIOIFOFKPN(int CJFNAFNJJLB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IEPIFCAFPHB<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> EDCLFPAMPKP(TRequest ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum BFIEPAHAOLK
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GEEEPANNAOI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float EFCEMNBMNEP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan JOKCGLHLIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int JGJAOPENFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public BFIEPAHAOLK HBKMBEFMMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly GEEEPANNAOI AMGMCPILGIN;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float IFFCLMFGDFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x48316B0", Offset = "0x4830AB0", VA = "0x1848316B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan FPIIMLNEMLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4831800", Offset = "0x4830C00", VA = "0x184831800")]
		public GEEEPANNAOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PCIAOFDDEAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest ANMDEHLLLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken LMNHDKIFBOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LNFGEEIEIAH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x52C7320", Offset = "0x52C6720", VA = "0x1852C7320")]
		public PCIAOFDDEAD(TRequest ANMDEHLLLBJ, TaskCompletionSource<TResult> LNFGEEIEIAH, CancellationToken LMNHDKIFBOH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct AANDKJJGMHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public IEPIFCAFPHB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x47CAE60", Offset = "0x47CA260", VA = "0x1847CAE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x47CB2C0", Offset = "0x47CA6C0", VA = "0x1847CB2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct JNANGDFDDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IEPIFCAFPHB<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PCIAOFDDEAD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C62C60", Offset = "0x4C62060", VA = "0x184C62C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C63240", Offset = "0x4C62640", VA = "0x184C63240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource EBBFGPINMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<PCIAOFDDEAD> MNGAJNBHCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GEEEPANNAOI AKKMPCJGDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EDCLFPAMPKP ADMLHNKOHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task NLKKAPLIOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BELOHMKLAOG;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x49E2AE0", Offset = "0x49E1EE0", VA = "0x1849E2AE0")]
	public IEPIFCAFPHB(EDCLFPAMPKP ADMLHNKOHEB, [Optional] GEEEPANNAOI AKKMPCJGDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x49E1570", Offset = "0x49E0970", VA = "0x1849E1570")]
	public Task<TResult> JJBONKGMIAG(TRequest ANMDEHLLLBJ, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x49E14A0", Offset = "0x49E08A0", VA = "0x1849E14A0")]
	private void HFPJPDLPCLC(PCIAOFDDEAD COPAOJNOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x49E1220", Offset = "0x49E0620", VA = "0x1849E1220")]
	[AsyncStateMachine(typeof(IEPIFCAFPHB<, >.AANDKJJGMHD))]
	private Task EJIHFGDFJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x49E1F20", Offset = "0x49E1320", VA = "0x1849E1F20")]
	private PCIAOFDDEAD NOAIAJECHLE()
	{
		return default(PCIAOFDDEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x49E1D30", Offset = "0x49E1130", VA = "0x1849E1D30")]
	[AsyncStateMachine(typeof(IEPIFCAFPHB<, >.JNANGDFDDIK))]
	private Task JOEBCLJNEFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x49E0E40", Offset = "0x49E0240", VA = "0x1849E0E40")]
	private void BOBKBEJPCHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x49E1040", Offset = "0x49E0440", VA = "0x1849E1040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class PNPJPACFHAL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> CEFIHBLEFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> LCLDLOCJKKK;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B50", Offset = "0x3E97F50", VA = "0x183E98B50", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool HMHCPPJANGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T JODHLAKLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x38F38E0", Offset = "0x38F2CE0", VA = "0x1838F38E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5327B90", Offset = "0x5326F90", VA = "0x185327B90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4772110", Offset = "0x4771510", VA = "0x184772110", Slot = "11")]
	public void Add(T MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5327410", Offset = "0x5326810", VA = "0x185327410")]
	public bool KHHMKEEJKGJ(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5327870", Offset = "0x5326C70", VA = "0x185327870", Slot = "15")]
	public bool Remove(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x50423B0", Offset = "0x50417B0", VA = "0x1850423B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x47B2020", Offset = "0x47B1420", VA = "0x1847B2020", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5326F30", Offset = "0x5326330", VA = "0x185326F30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5326FD0", Offset = "0x53263D0", VA = "0x185326FD0", Slot = "13")]
	public bool Contains(T MGCEJOCCONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5327020", Offset = "0x5326420", VA = "0x185327020", Slot = "14")]
	public void CopyTo(T[] LLPLHOOOAEB, int KIMBCLMGPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6220", Offset = "0x4DE5620", VA = "0x184DE6220", Slot = "6")]
	public int IndexOf(T MGCEJOCCONP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5327080", Offset = "0x5326480", VA = "0x185327080", Slot = "7")]
	public void Insert(int CJFNAFNJJLB, T MGCEJOCCONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5327510", Offset = "0x5326910", VA = "0x185327510", Slot = "8")]
	public void RemoveAt(int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5327930", Offset = "0x5326D30", VA = "0x185327930")]
	public PNPJPACFHAL()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x28A1A30", Offset = "0x28A0E30", VA = "0x1828A1A30")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x23ECD90", Offset = "0x23EC190", VA = "0x1823ECD90")]
		public SerializedGuid([In] Guid KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x784E490", Offset = "0x784D890", VA = "0x18784E490")]
		public static SerializedGuid JOIDBKAHEAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x784E420", Offset = "0x784D820", VA = "0x18784E420")]
		public static SerializedGuid JCPJDEJENHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x784E510", Offset = "0x784D910", VA = "0x18784E510")]
		public bool KCBHPIPJOPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x784E5F0", Offset = "0x784D9F0", VA = "0x18784E5F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x784E570", Offset = "0x784D970", VA = "0x18784E570", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x784E340", Offset = "0x784D740", VA = "0x18784E340", Slot = "7")]
		public bool Equals(SerializedGuid KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x784E380", Offset = "0x784D780", VA = "0x18784E380", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x784E410", Offset = "0x784D810", VA = "0x18784E410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x784E310", Offset = "0x784D710", VA = "0x18784E310", Slot = "6")]
		public int CompareTo(SerializedGuid KNCKFHOKGJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NAPJEGFLAEO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type NHHPIACHOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string FOBGOIBFLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AIHFIMGFLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool LPPCMCBIDHJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x784CE10", Offset = "0x784C210", VA = "0x18784CE10")]
	public NAPJEGFLAEO(Type FCENGGJIDNA, string MEHBCEOHLFK, bool FJGPONGLDJF = false, bool FMOKPJDOKBA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, [Optional] float? AHIKEFMGEKC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJEMNCEDADJ();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class FIEPLLDLKLJ<T> : BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class BGFGMGHIBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float OKGGONCOGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BGFGMGHIBJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class MCNOPHBJLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public MCNOPHBJLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x501B0D0", Offset = "0x501A4D0", VA = "0x18501B0D0")]
		internal bool JNKILBHFNEN(BGFGMGHIBJB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float LMJKHCBKNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float BPAHIDGOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<BGFGMGHIBJB> EJNHCEEFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private MAEKECGNICD<BGFGMGHIBJB> LEABAFMLNDM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x47447A0", Offset = "0x4743BA0", VA = "0x1847447A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4744BA0", Offset = "0x4743FA0", VA = "0x184744BA0")]
	public FIEPLLDLKLJ(float EDPKCBHJJIM, float JFFGOMGDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4744810", Offset = "0x4743C10", VA = "0x184744810", Slot = "6")]
	public bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4744210", Offset = "0x4743610", VA = "0x184744210", Slot = "5")]
	public IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, float? AHIKEFMGEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4743DF0", Offset = "0x47431F0", VA = "0x184743DF0", Slot = "7")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4744580", Offset = "0x4743980", VA = "0x184744580")]
	private void IKKDDNFEAMI(float GLBFMHKMALN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FOPFBPHAIDO<T> : BAIOKONMKJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct ACEHAEGGKAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float OKGGONCOGKK;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x47EA350", Offset = "0x47E9750", VA = "0x1847EA350")]
		public ACEHAEGGKAI(T FFOEEMKIKJO, float GLBFMHKMALN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FEPKFECIALC : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FOPFBPHAIDO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public FEPKFECIALC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4706780", Offset = "0x4705B80", VA = "0x184706780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4706D40", Offset = "0x4706140", VA = "0x184706D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4706AF0", Offset = "0x4705EF0", VA = "0x184706AF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4706CB0", Offset = "0x47060B0", VA = "0x184706CB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float EDPKCBHJJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float JFFGOMGDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<ACEHAEGGKAI> EJNHCEEFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int GNPKFMEIDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DOGDNKHLKAL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int CABELAFBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x993220", Offset = "0x992620", VA = "0x180993220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4757F20", Offset = "0x4757320", VA = "0x184757F20")]
	public FOPFBPHAIDO(float EDPKCBHJJIM, float JFFGOMGDEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4757A30", Offset = "0x4756E30", VA = "0x184757A30", Slot = "6")]
	public bool NJEOCINJPPK(float GLBFMHKMALN, T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4757730", Offset = "0x4756B30", VA = "0x184757730", Slot = "8")]
	public int JEMBEAPNKLB(float GLBFMHKMALN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4757240", Offset = "0x4756640", VA = "0x184757240", Slot = "5")]
	[IteratorStateMachine(typeof(FOPFBPHAIDO<>.FEPKFECIALC))]
	public IEnumerable<T> GFLOCMEJEDF(float GLBFMHKMALN, float? AHIKEFMGEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x47571E0", Offset = "0x47565E0", VA = "0x1847571E0", Slot = "7")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4757640", Offset = "0x4756A40", VA = "0x184757640")]
	private void JDKKLNCPHBB(float GLBFMHKMALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x47573C0", Offset = "0x47567C0", VA = "0x1847573C0")]
	private ACEHAEGGKAI HKABOLJEKDA()
	{
		return default(ACEHAEGGKAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class APGKENHKANG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct LOKNLOBIGNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long HGBCBCFFBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long HNOGAPJKIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int JIPAJPFKINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int MBJFKBCPAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool INJOOHFGCPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string GFBGIIKFMLP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4E58030", Offset = "0x4E57430", VA = "0x184E58030")]
		public LOKNLOBIGNI(long HGBCBCFFBCK, int JIPAJPFKINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4E580A0", Offset = "0x4E574A0", VA = "0x184E580A0")]
		public LOKNLOBIGNI(long HGBCBCFFBCK, long HNOGAPJKIEF, int JIPAJPFKINJ, int MBJFKBCPAMB, bool INJOOHFGCPP, string GFBGIIKFMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4E57EC0", Offset = "0x4E572C0", VA = "0x184E57EC0")]
		public int DKGPAFNCELB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4E57F10", Offset = "0x4E57310", VA = "0x184E57F10")]
		public int DPMPPJINDMB(int ODCMILIFNPO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4E57F30", Offset = "0x4E57330", VA = "0x184E57F30")]
		public double MJOEDDGOAEB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4E57F90", Offset = "0x4E57390", VA = "0x184E57F90")]
		public LOKNLOBIGNI MLDHBAPAGCG(long HNOGAPJKIEF, int MBJFKBCPAMB)
		{
			return default(LOKNLOBIGNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class EEEKGBDKLHP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct IOABIGGCIMC<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public EEEKGBDKLHP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<EEEKGBDKLHP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private EEEKGBDKLHP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x49FE2C0", Offset = "0x49FD6C0", VA = "0x1849FE2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x4902E00", Offset = "0x4902200", VA = "0x184902E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey KKGMNHPHOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly APGKENHKANG<TKey> KINEPAABOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly GBHBOJAPDOA DPDKJPMBJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<EEEKGBDKLHP> MGJABHCKIPE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string AHGEGEPEODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x42B5B70", Offset = "0x42B4F70", VA = "0x1842B5B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<EEEKGBDKLHP> GHOJKGPMAPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x42B5B30", Offset = "0x42B4F30", VA = "0x1842B5B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LOKNLOBIGNI DOFCGFPGEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x42B5BC0", Offset = "0x42B4FC0", VA = "0x1842B5BC0")]
			[CompilerGenerated]
			get
			{
				return default(LOKNLOBIGNI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x42B5700", Offset = "0x42B4B00", VA = "0x1842B5700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x42B5BE0", Offset = "0x42B4FE0", VA = "0x1842B5BE0")]
		internal EEEKGBDKLHP(APGKENHKANG<TKey> KINEPAABOFB, TKey DJBLFBEBKGO, GBHBOJAPDOA DPDKJPMBJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x42B5980", Offset = "0x42B4D80", VA = "0x1842B5980")]
		public EEEKGBDKLHP IDDABEAKABA(TKey DJBLFBEBKGO, [Optional] GBHBOJAPDOA? MPKBCOMOPAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3A60750", Offset = "0x3A5FB50", VA = "0x183A60750")]
		[AsyncStateMachine(typeof(IOABIGGCIMC<>))]
		public Task<T> MMBOAJEGAPH<T>(TKey DJBLFBEBKGO, Func<EEEKGBDKLHP, Task<T>> MOIIPMBKBLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x42B5730", Offset = "0x42B4B30", VA = "0x1842B5730", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class BAKIEINEMAA : IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, LOKNLOBIGNI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public APGKENHKANG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, LOKNLOBIGNI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, LOKNLOBIGNI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x28A1FC0", Offset = "0x28A13C0", VA = "0x1828A1FC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LOKNLOBIGNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5AEDD70", Offset = "0x5AED170", VA = "0x185AEDD70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28A20B0", Offset = "0x28A14B0", VA = "0x1828A20B0")]
		[DebuggerHidden]
		public BAKIEINEMAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x477BBD0", Offset = "0x477AFD0", VA = "0x18477BBD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5AED860", Offset = "0x5AECC60", VA = "0x185AED860", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDC00", Offset = "0x5AED000", VA = "0x185AEDC00")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDD20", Offset = "0x5AED120", VA = "0x185AEDD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDC50", Offset = "0x5AED050", VA = "0x185AEDC50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4783C60", Offset = "0x4783060", VA = "0x184783C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AEPOKMJJMCH : IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, LOKNLOBIGNI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private EEEKGBDKLHP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EEEKGBDKLHP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public APGKENHKANG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<EEEKGBDKLHP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, LOKNLOBIGNI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, LOKNLOBIGNI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x28A1FC0", Offset = "0x28A13C0", VA = "0x1828A1FC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LOKNLOBIGNI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x47F2790", Offset = "0x47F1B90", VA = "0x1847F2790", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28A20B0", Offset = "0x28A14B0", VA = "0x1828A20B0")]
		[DebuggerHidden]
		public AEPOKMJJMCH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x47F27F0", Offset = "0x47F1BF0", VA = "0x1847F27F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x47F1D70", Offset = "0x47F1170", VA = "0x1847F1D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x47F25A0", Offset = "0x47F19A0", VA = "0x1847F25A0")]
		private void OMCGPHJKBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x47F2540", Offset = "0x47F1940", VA = "0x1847F2540")]
		private void NIIFAIKAHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x47F2740", Offset = "0x47F1B40", VA = "0x1847F2740", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x47F2600", Offset = "0x47F1A00", VA = "0x1847F2600", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LOKNLOBIGNI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x47F2700", Offset = "0x47F1B00", VA = "0x1847F2700", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<APGKENHKANG<TKey>, GBHBOJAPDOA> NJBPJLLOBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly EEEKGBDKLHP FGCDOGNIMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NKBHHLLPGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch GPLEFDGILMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int JBHEEPLOECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string ILMDEMKACAI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EEEKGBDKLHP PEMAJFGNIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string AHGEGEPEODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4A22940", Offset = "0x4A21D40", VA = "0x184A22940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4A229A0", Offset = "0x4A21DA0", VA = "0x184A229A0")]
	public APGKENHKANG(TKey FADNPBNCDAH, GBHBOJAPDOA DPDKJPMBJOA, [Optional] int? JIPAJPFKINJ, [Optional][CanBeNull] Stopwatch GPLEFDGILMF, [Optional] Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK, [Optional] Action<TKey, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM, [Optional] Action<APGKENHKANG<TKey>, GBHBOJAPDOA> NJBPJLLOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4A22670", Offset = "0x4A21A70", VA = "0x184A22670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4A22820", Offset = "0x4A21C20", VA = "0x184A22820")]
	[IteratorStateMachine(typeof(APGKENHKANG<>.BAKIEINEMAA))]
	public IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)> GKMHPFGADCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4A22740", Offset = "0x4A21B40", VA = "0x184A22740")]
	[IteratorStateMachine(typeof(APGKENHKANG<>.AEPOKMJJMCH))]
	private IEnumerable<(TKey, List<TKey>, LOKNLOBIGNI)> GKMHPFGADCI(List<TKey> IOOOOBAIEAN, EEEKGBDKLHP GHLKOGBLJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A228C0", Offset = "0x4A21CC0", VA = "0x184A228C0")]
	private (long, int) HEJIEJPJLHD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class LDGGCOKCCHF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected LDGGCOKCCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class IEEEACGACAC<TKey> : LDGGCOKCCHF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string LPBGOLKAGFJ(TKey DJBLFBEBKGO);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x49DA330", Offset = "0x49D9730", VA = "0x1849DA330")]
	private static string FFBGDLPHJBG(TKey DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x49DA4C0", Offset = "0x49D98C0", VA = "0x1849DA4C0", Slot = "4")]
	public override string OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x49DA370", Offset = "0x49D9770", VA = "0x1849DA370")]
	public string OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB, [NotNull] LPBGOLKAGFJ LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BACDFOLGNCI(APGKENHKANG<TKey> KINEPAABOFB, [NotNull] LPBGOLKAGFJ LGIBBHPPOAC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x49DA5A0", Offset = "0x49D99A0", VA = "0x1849DA5A0")]
	protected IEEEACGACAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KIBMIDFCMIN<TKey> : LDGGCOKCCHF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string DJNMHLKLKPN(TKey DJBLFBEBKGO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string KFJGGCNEALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double BMIFEHBAEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool DINIKCNDHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int DFGDBBPNANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> FNFKBKNGBGM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4D72230", Offset = "0x4D71630", VA = "0x184D72230")]
	private static string FFBGDLPHJBG(TKey DJBLFBEBKGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4D72E40", Offset = "0x4D72240", VA = "0x184D72E40")]
	public KIBMIDFCMIN(string KFJGGCNEALL = "F2", double BMIFEHBAEJG = double.MaxValue, bool DINIKCNDHLA = false, int DFGDBBPNANF = int.MaxValue, [Optional] ISet<string> FNFKBKNGBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4D72990", Offset = "0x4D71D90", VA = "0x184D72990", Slot = "4")]
	public override Dictionary<string, string> OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4D72270", Offset = "0x4D71670", VA = "0x184D72270")]
	private bool LEGEAKMNBAN(string HNHKIDAKLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4D72350", Offset = "0x4D71750", VA = "0x184D72350")]
	public Dictionary<string, string> OEMPKGNJGAC(APGKENHKANG<TKey> KINEPAABOFB, DJNMHLKLKPN LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4D72BD0", Offset = "0x4D71FD0", VA = "0x184D72BD0")]
	private string PGPGHHMEOMD(StringBuilder ADAKNFBJHBN, List<TKey> GCOMIIIIMMM, DJNMHLKLKPN LGIBBHPPOAC, bool HNDIHOFCEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4D72A70", Offset = "0x4D71E70", VA = "0x184D72A70")]
	private static void PGIBILCDDDJ(StringBuilder CONGGHBKFOJ, string AECMHGBNGDN, bool EMGNAJIGBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ILLDDAHPMOO<TKey> : IEEEACGACAC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BJLGKAGNFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public LPBGOLKAGFJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static ILLDDAHPMOO<TKey> DNEPPKLGBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] AGDCJEAMPDC;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x49F8FD0", Offset = "0x49F83D0", VA = "0x1849F8FD0")]
	private ILLDDAHPMOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x49F7F70", Offset = "0x49F7370", VA = "0x1849F7F70", Slot = "5")]
	protected override string BACDFOLGNCI(APGKENHKANG<TKey> KINEPAABOFB, LPBGOLKAGFJ LGIBBHPPOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x49F8D90", Offset = "0x49F8190", VA = "0x1849F8D90")]
	[CompilerGenerated]
	internal static string PLLBLFPEOHA(string FOALADOIBAE, TKey DJBLFBEBKGO, BJLGKAGNFPD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class ADJCNDJOHAC : APGKENHKANG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AKGIMJNJHIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<ADJCNDJOHAC, GBHBOJAPDOA> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public AKGIMJNJHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7848F00", Offset = "0x7848300", VA = "0x187848F00")]
		internal void JGENPHPFIGL(APGKENHKANG<string> timer, GBHBOJAPDOA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7848A00", Offset = "0x7847E00", VA = "0x187848A00")]
	public ADJCNDJOHAC(GBHBOJAPDOA DPDKJPMBJOA, [Optional] string COMBJFMBCJD, [Optional] int? JIPAJPFKINJ, [Optional] Stopwatch GPLEFDGILMF, [Optional] Action<string, LOKNLOBIGNI, GBHBOJAPDOA> PPPCMOMONEK, [Optional] Action<string, LOKNLOBIGNI, GBHBOJAPDOA> HLCLJOECALM, [Optional] Action<ADJCNDJOHAC, GBHBOJAPDOA> NJBPJLLOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7848940", Offset = "0x7847D40", VA = "0x187848940")]
	private static Action<APGKENHKANG<string>, GBHBOJAPDOA> BHJBFKNGHFK(Action<ADJCNDJOHAC, GBHBOJAPDOA> ADLKPPBLCIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class FMHENKFEBAH
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HOCFDIPJHPH : FMHENKFEBAH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static FMHENKFEBAH DNEPPKLGBFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x784B750", Offset = "0x784AB50", VA = "0x18784B750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float KFDEODFGGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x10B9A10", Offset = "0x10B8E10", VA = "0x1810B9A10", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x784B850", Offset = "0x784AC50", VA = "0x18784B850")]
		public HOCFDIPJHPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static FMHENKFEBAH ANILNGLEINJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static FMHENKFEBAH AMGMCPILGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7849F80", Offset = "0x7849380", VA = "0x187849F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float KFDEODFGGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected FMHENKFEBAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface MFCONHIDCBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HLFDOLJKNKL<T> : MFCONHIDCBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FMGKLBADKGB
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x35C14B0", Offset = "0x35C08B0", VA = "0x1835C14B0")]
	public static HLFDOLJKNKL<TResource> IPPNJGDNINP<TResource, TId>(this NJGLBGPNBMB<TId, TResource> OEEONBHNECC, TId NCJKGMLAKGH, [Optional] Func<TId, CancellationToken, Task<TResource>>? EBOPNJLKNFL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FFECFGBFNPG
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class GNDMNCLHJCB<T> : MLJCOMBFFFI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override GOBMEFCJDOP<T?> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x485D250", Offset = "0x485C650", VA = "0x18485D250")]
		public GNDMNCLHJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ABIADBEIMON<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T NCGFNDEHOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? MNLBIHAIHOF;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x47E4160", Offset = "0x47E3560", VA = "0x1847E4160")]
		public ABIADBEIMON(T MEBMOMPAGGP, Action<T>? JECALFIKEFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x47E3F20", Offset = "0x47E3320", VA = "0x1847E3F20", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class COMHHJECDBC<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x64121B0", Offset = "0x64115B0", VA = "0x1864121B0")]
		public COMHHJECDBC(Exception DLAPGFGBDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class MAOAJJJMHFC<T> : MLJCOMBFFFI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct AMOFIJHGFEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<HLFDOLJKNKL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<HLFDOLJKNKL<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4A1F550", Offset = "0x4A1E950", VA = "0x184A1F550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4A1FF30", Offset = "0x4A1F330", VA = "0x184A1FF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JFCLPANPIPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<HLFDOLJKNKL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<HLFDOLJKNKL<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4BE49A0", Offset = "0x4BE3DA0", VA = "0x184BE49A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4BE4C30", Offset = "0x4BE4030", VA = "0x184BE4C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<HLFDOLJKNKL<T>> CHPNEKBOFFL;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override GOBMEFCJDOP<T> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5012E30", Offset = "0x5012230", VA = "0x185012E30")]
		public MAOAJJJMHFC(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5012D10", Offset = "0x5012110", VA = "0x185012D10", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x50129E0", Offset = "0x5011DE0", VA = "0x1850129E0")]
		[AsyncStateMachine(typeof(MAOAJJJMHFC<>.AMOFIJHGFEM))]
		[CompilerGenerated]
		internal static Task<T> HLNLODDOEAJ(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5012C30", Offset = "0x5012030", VA = "0x185012C30")]
		[AsyncStateMachine(typeof(MAOAJJJMHFC<>.JFCLPANPIPE))]
		[CompilerGenerated]
		internal static Task OBOAJODIOGK(Task<HLFDOLJKNKL<T>> NHNFPALEEPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class GJGMLILAKPK<TIn, TOut> : MLJCOMBFFFI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct HKGHAOFJLCJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4904540", Offset = "0x4903940", VA = "0x184904540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x483E0E0", Offset = "0x483D4E0", VA = "0x18483E0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly HLFDOLJKNKL<TIn> COBGPFOHNIN;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> NMBCJEBMAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override GOBMEFCJDOP<TOut> GOAEODBEMGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9943D0", Offset = "0x9937D0", VA = "0x1809943D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x4843DA0", Offset = "0x48431A0", VA = "0x184843DA0")]
		public GJGMLILAKPK(HLFDOLJKNKL<TIn> AFIBHOKGKBP, Func<TIn, TOut> ICNECFGJGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4843D00", Offset = "0x4843100", VA = "0x184843D00", Slot = "10")]
		protected override void PJDDAEBFGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4843A00", Offset = "0x4842E00", VA = "0x184843A00")]
		[AsyncStateMachine(typeof(GJGMLILAKPK<, >.HKGHAOFJLCJ))]
		[CompilerGenerated]
		internal static Task<TOut> LNLGBGAEJJK(Task<TIn> JLGCIHFLEAI, Func<TIn, TOut> ICNECFGJGLI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x35BE0A0", Offset = "0x35BD4A0", VA = "0x1835BE0A0")]
	public static HLFDOLJKNKL<T> GBADJOAJCAL<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x35BDFF0", Offset = "0x35BD3F0", VA = "0x1835BDFF0")]
	public static HLFDOLJKNKL<T> CKGJIBIMFON<T>(T HBALBIOOGIJ, [Optional] Action<T>? JECALFIKEFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static HLFDOLJKNKL<T> IHGHECCEGBJ<T>(Exception DLAPGFGBDMP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x337DEA0", Offset = "0x337D2A0", VA = "0x18337DEA0")]
	public static HLFDOLJKNKL<T> MKCDEGCPFIA<T>(Task<HLFDOLJKNKL<T>> NHNFPALEEPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3385030", Offset = "0x3384430", VA = "0x183385030")]
	public static HLFDOLJKNKL<TOut> IGBFJKOBHIJ<TOut, TIn>(HLFDOLJKNKL<TIn> GGBKPDHLOJF, Func<TIn, TOut> ICNECFGJGLI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class MLJCOMBFFFI<T> : HLFDOLJKNKL<T>, MFCONHIDCBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string PNHOBBMPKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly MLHHDOMPAAM KIGNAOJEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MPMNNGFDLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xBE3600", Offset = "0xBE2A00", VA = "0x180BE3600", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5065B20", Offset = "0x5064F20", VA = "0x185065B20")]
	public MLJCOMBFFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5065860", Offset = "0x5064C60", VA = "0x185065860", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PJDDAEBFGNH();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class KKJEIOEMIAF<TTask, T> : MLJCOMBFFFI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class BGODFFEFMPC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BGODFFEFMPC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3E87150", Offset = "0x3E86550", VA = "0x183E87150", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3E87410", Offset = "0x3E86810", VA = "0x183E87410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public KKJEIOEMIAF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public BGODFFEFMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5E59EA0", Offset = "0x5E592A0", VA = "0x185E59EA0")]
		[AsyncStateMachine(typeof(KKJEIOEMIAF<, >.BGODFFEFMPC.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JOMFDIGPIOJ(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> NHNFPALEEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource MCOIFPENEFF;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CB0", Offset = "0x4D810B0", VA = "0x184D81CB0")]
	protected KKJEIOEMIAF(TTask NHNFPALEEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4D81A60", Offset = "0x4D80E60", VA = "0x184D81A60", Slot = "10")]
	protected override void PJDDAEBFGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T MFPNANIKEBM(TTask LNJEGKCLOPP);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DDHGIEAEBOC();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class FFAOIBHIFOE<T> : MLJCOMBFFFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OHGHKHJHGOP<Task<T>> KNCAMNOGLIO;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> NMBCJEBMAFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4706DD0", Offset = "0x47061D0", VA = "0x184706DD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override GOBMEFCJDOP<T> GOAEODBEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4706E40", Offset = "0x4706240", VA = "0x184706E40")]
	public FFAOIBHIFOE(OHGHKHJHGOP<Task<T>> LIFCDIEMBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4706E20", Offset = "0x4706220", VA = "0x184706E20", Slot = "10")]
	protected override void PJDDAEBFGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class EDFPDAKGIPE
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName MNBDDCKJCBA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> KFINNJFDOJI;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7849BA0", Offset = "0x7848FA0", VA = "0x187849BA0")]
	public static int MKBININHGNE(this LKHFDMEDDEH NIILNBGHOGD, IncrementalHash FJJIBEAAGGP, byte[] DGPJNOICFAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7849B40", Offset = "0x7848F40", VA = "0x187849B40")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7849500", Offset = "0x7848900", VA = "0x187849500")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7849810", Offset = "0x7848C10", VA = "0x187849810")]
	public static bool DELMBPOOKMM([CanBeNull] this LKHFDMEDDEH NIILNBGHOGD, IncrementalHash FJJIBEAAGGP, byte[] DGPJNOICFAE, [Out] string AFHGIBDEPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7849470", Offset = "0x7848870", VA = "0x187849470")]
	private static bool DAKKBDCDKGN(byte[] CBINPPOGPMG, Span<byte> MDIDHDICDLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class AIIAJFHIPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7848B50", Offset = "0x7847F50", VA = "0x187848B50")]
	public static int IKBGHBHMDDP(HashAlgorithmName KIIKIPAHABI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7848CA0", Offset = "0x78480A0", VA = "0x187848CA0")]
	public static int MKBININHGNE(this ELOKANIMHDL EMBJEJOKJKK, byte[] DMBBNCKBGLA, IncrementalHash FJJIBEAAGGP, byte[] EGDECGMODBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface ELOKANIMHDL
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FJJIBEAAGGP);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LKHFDMEDDEH : ELOKANIMHDL
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] GFLBGJDCICK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] IPKFKGPBAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KOJFMAIPKEH
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool AEPKNNLBGOC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> OFFKFILGJMJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> DIMNPCOBEBJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding PGMBLALIFNH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> GLIAHPGLMIL;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x36DA340", Offset = "0x36D9740", VA = "0x1836DA340")]
	public static void JDPCIEGHHIA<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] T DMJKAPFLGHP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x36DA400", Offset = "0x36D9800", VA = "0x1836DA400")]
	public static void PNNLOFBHPHK<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] T EMBJEJOKJKK) where T : ELOKANIMHDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x36D97F0", Offset = "0x36D8BF0", VA = "0x1836D97F0")]
	public static void HLKMCLAKBFG<T>(this IncrementalHash KOFJKIPNADB, [CanBeNull] IList<T> HICJLFMOIPD) where T : ELOKANIMHDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x784BC70", Offset = "0x784B070", VA = "0x18784BC70")]
	private static bool ECLNJPNNIEO([CanBeNull] ELOKANIMHDL EMBJEJOKJKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x784BF90", Offset = "0x784B390", VA = "0x18784BF90")]
	public static void IJMJHAEHEDP(this IncrementalHash FJJIBEAAGGP, string? GDDJCAFFEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x784BD60", Offset = "0x784B160", VA = "0x18784BD60")]
	public static void GOANJCHDMKD(this IncrementalHash FJJIBEAAGGP, long HKCLOHHKEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x784C740", Offset = "0x784BB40", VA = "0x18784C740")]
	public static void PHCPLCCGIPL(this IncrementalHash FJJIBEAAGGP, int NKPENDLBPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x784C510", Offset = "0x784B910", VA = "0x18784C510")]
	public static void LKOMBFOHBMM(this IncrementalHash FJJIBEAAGGP, short LKAFGFHHPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x784BB00", Offset = "0x784AF00", VA = "0x18784BB00")]
	public static void AIDCEMNFMCD(this IncrementalHash FJJIBEAAGGP, byte BKKDMGOKLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x784C3A0", Offset = "0x784B7A0", VA = "0x18784C3A0")]
	public static void JOFCNOCNIKL(this IncrementalHash FJJIBEAAGGP, bool CNJMAGIHGPL, bool ONCGGDCALGL = false, bool KNNKMCLLFAO = false, bool DDEGIKNOIPK = false, bool OPIJEDPIPLB = false, bool BIDOBGCEFLL = false, bool HHDHJADEJHB = false, bool LOONGLFOANP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x36D9D10", Offset = "0x36D9110", VA = "0x1836D9D10")]
	public static void IMKPAOJDAAC<T>(this IncrementalHash FJJIBEAAGGP, T OEAPKNBFGIB) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x784BF30", Offset = "0x784B330", VA = "0x18784BF30")]
	public static void IBBCNFKHDJD(this IncrementalHash FJJIBEAAGGP, float IPOJAFEDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x784C6E0", Offset = "0x784BAE0", VA = "0x18784C6E0")]
	public static void NCDLIAGPNGH(this IncrementalHash FJJIBEAAGGP, ulong LJBLMKBHCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x784BC10", Offset = "0x784B010", VA = "0x18784BC10")]
	public static void BMILNKIEKDD(this IncrementalHash FJJIBEAAGGP, uint PPHDBPODCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x784BD00", Offset = "0x784B100", VA = "0x18784BD00")]
	public static void ECOBIEKEAKD(this IncrementalHash FJJIBEAAGGP, ushort AEADDOCPHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x784B9D0", Offset = "0x784ADD0", VA = "0x18784B9D0")]
	public static void AAJLHHMENBD(this IncrementalHash FJJIBEAAGGP, Vector3 PFJGOOFAJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class JBABNFFJPNF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x784B8A0", Offset = "0x784ACA0", VA = "0x18784B8A0")]
	public JBABNFFJPNF(string DAMFJFKKFBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class PMDPBPHBBFM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void MBDCHGLIEPN(ushort EKLOHJMDKGM, ushort NBMJHKFONKH, ushort FENLJLPCNHO, ushort OJBMABLMPGO);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void MIAFLBGLODM(ushort CIKDOLJDJGN, ushort NFCGNAGPPGB);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void DNEOIIDHONC();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort MPIMBGDHPOE = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	protected PMDPBPHBBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class BLKDPIONGMN<T> : PMDPBPHBBFM where T : BLKDPIONGMN<T>.IMANFHHDMDP
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface IMANFHHDMDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		MIAFLBGLODM COJIHNLEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		MIAFLBGLODM EIBDNBDMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		DNEOIIDHONC CIICAGDOHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> KGCLPNMOOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private DNEOIIDHONC JOEEIONHMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private DNEOIIDHONC BMBPADNOEJM;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OCOKAOCMFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9FB880", Offset = "0x9FAC80", VA = "0x1809FB880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x99D7E0", Offset = "0x99CBE0", VA = "0x18099D7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort CBKADNMALJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5F51F10", Offset = "0x5F51310", VA = "0x185F51F10")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F51F30", Offset = "0x5F51330", VA = "0x185F51F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort PDOHAGODAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5F51F20", Offset = "0x5F51320", VA = "0x185F51F20")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F52570", Offset = "0x5F51970", VA = "0x185F52570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort NJPMMPHBJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD2A070", Offset = "0xD29470", VA = "0x180D2A070")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xD2A190", Offset = "0xD29590", VA = "0x180D2A190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort ICGJDIOEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5F52240", Offset = "0x5F51640", VA = "0x185F52240")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F51F40", Offset = "0x5F51340", VA = "0x185F51F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool MEFBFDBMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1675CB0", Offset = "0x16750B0", VA = "0x181675CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool CFIALOJCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xDE26D0", Offset = "0xDE1AD0", VA = "0x180DE26D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MBDCHGLIEPN BLHDJBBMJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5F521A0", Offset = "0x5F515A0", VA = "0x185F521A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5F524D0", Offset = "0x5F518D0", VA = "0x185F524D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5F51FC0", Offset = "0x5F513C0", VA = "0x185F51FC0")]
	private T FHGKCJMIFIF(ushort NMCDDILMCNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5F52080", Offset = "0x5F51480", VA = "0x185F52080")]
	private T GBLEGLPCBJM(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5F52140", Offset = "0x5F51540", VA = "0x185F52140")]
	protected T GNMPFEBLNMH(uint FCAIMBBLMLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5F53010", Offset = "0x5F52410", VA = "0x185F53010")]
	protected BLKDPIONGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5F52690", Offset = "0x5F51A90", VA = "0x185F52690")]
	public void PBMICBBKGKN(ushort IPCNFMBMGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5F526D0", Offset = "0x5F51AD0", VA = "0x185F526D0")]
	public void PBMICBBKGKN(ushort IPCNFMBMGEN, ushort GCAMIHKBBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5F52580", Offset = "0x5F51980", VA = "0x185F52580", Slot = "4")]
	protected virtual void PBMICBBKGKN(uint ALEPOIEEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F527E0", Offset = "0x5F51BE0", VA = "0x185F527E0")]
	protected void PNHHALOPJNJ(uint ALEPOIEEKFN, uint IMIDEBIHKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5F52730", Offset = "0x5F51B30", VA = "0x185F52730")]
	protected void PBPANFKGEOA(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP, T DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5F51F50", Offset = "0x5F51350", VA = "0x185F51F50")]
	private void EDKJMGADMPP(uint FCAIMBBLMLM, T DHJOIBPBMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5F52260", Offset = "0x5F51660", VA = "0x185F52260")]
	protected void JPLPCDLPAIH(float JNFHMFBFJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5F52250", Offset = "0x5F51650", VA = "0x185F52250")]
	protected uint JNPLIIHFLGN(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5F52070", Offset = "0x5F51470", VA = "0x185F52070")]
	protected ushort FNPKIDBKMKA(uint CAFEMCHINAO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5F51FB0", Offset = "0x5F513B0", VA = "0x185F51FB0")]
	protected ushort FBDFFHGLBIL(uint CAFEMCHINAO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class EHNKAICOMAE : BLKDPIONGMN<EHNKAICOMAE.PAPDADFBCBM>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class PAPDADFBCBM : IMANFHHDMDP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public MIAFLBGLODM COJIHNLEBNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public MIAFLBGLODM EIBDNBDMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public DNEOIIDHONC CIICAGDOHAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public PAPDADFBCBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7849DC0", Offset = "0x78491C0", VA = "0x187849DC0")]
	public void OOIDMJKAOHG(ushort OHKAEGPBKDI, MIAFLBGLODM BEIFOMBFMKA, MIAFLBGLODM AIPBFIAFNMI, DNEOIIDHONC DABMHPHNEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7849EA0", Offset = "0x78492A0", VA = "0x187849EA0")]
	public void OOIDMJKAOHG(ushort NMCDDILMCNJ, ushort GDMGCBCMHBP, MIAFLBGLODM BEIFOMBFMKA, MIAFLBGLODM AIPBFIAFNMI, DNEOIIDHONC DABMHPHNEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7849D70", Offset = "0x7849170", VA = "0x187849D70")]
	public void ODNOMLGNGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7849330", Offset = "0x7848730", VA = "0x187849330")]
	protected EHNKAICOMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CNIKIJHBKDD : EHNKAICOMAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool LNNNHLFANLN;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool LCONPCPHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xB583E0", Offset = "0xB577E0", VA = "0x180B583E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC4B280", Offset = "0xC4A680", VA = "0x180C4B280")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7849270", Offset = "0x7848670", VA = "0x187849270")]
	public void GDCNGOALEGL(ushort MPCDGJNKAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x78492D0", Offset = "0x78486D0", VA = "0x1878492D0")]
	public void GDCNGOALEGL(ushort MPCDGJNKAKK, ushort AADPGAALLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7849330", Offset = "0x7848730", VA = "0x187849330")]
	public CNIKIJHBKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class IADDFIIACED<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class OFAGCFKONIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode JOCJBPPJMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode KLDFHLFOOFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NOLCDBENBPB EAOBCLAGGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<NOLCDBENBPB> HKPAHCNOJHN;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public OFAGCFKONIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct NOLCDBENBPB : IComparable<NOLCDBENBPB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int PKKOAIHLPOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant DIMNBLIIFEB;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1536EA0", Offset = "0x15362A0", VA = "0x181536EA0")]
		public NOLCDBENBPB(int PKKOAIHLPOK, TClaimant DIMNBLIIFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x50ED100", Offset = "0x50EC500", VA = "0x1850ED100")]
		public bool HNHELJCGNOA([In] NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x50ED0F0", Offset = "0x50EC4F0", VA = "0x1850ED0F0")]
		public bool GBDFDLCCGMC([In] NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x50ED0E0", Offset = "0x50EC4E0", VA = "0x1850ED0E0", Slot = "4")]
		public int CompareTo(NOLCDBENBPB KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x50ED160", Offset = "0x50EC560", VA = "0x1850ED160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum LGNPMPEALFL
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class DFNOMGIKOJP : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public IADDFIIACED<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xDE6750", Offset = "0xDE5B50", VA = "0x180DE6750")]
		[DebuggerHidden]
		public DFNOMGIKOJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x666F0E0", Offset = "0x666E4E0", VA = "0x18666F0E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x666F2C0", Offset = "0x666E6C0", VA = "0x18666F2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x666F1C0", Offset = "0x666E5C0", VA = "0x18666F1C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x477D180", Offset = "0x477C580", VA = "0x18477D180", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly MAEKECGNICD<OFAGCFKONIE> CBHIBKPDLJC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly MAEKECGNICD<List<NOLCDBENBPB>> HHKGMFDNLEJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int HCHLCNCEOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> EMGNCJKEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, OFAGCFKONIE> ELNCGMPFJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LGNPMPEALFL KGLDBFDNHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool EKDCONIHOMM;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode FCPKINCBMMM(TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DGEGGCNKMJN(TNode BLGGFHHEDNC, TClaimant GICEDMPAJKO, TClaimant HDKGNBABBNF);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x49C8DE0", Offset = "0x49C81E0", VA = "0x1849C8DE0")]
	public IADDFIIACED(LGNPMPEALFL KGLDBFDNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x49C7800", Offset = "0x49C6C00", VA = "0x1849C7800")]
	public void FHFNEJPKFMJ(TNode BLGGFHHEDNC, TNode BBFFOKPDHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x49C8A90", Offset = "0x49C7E90", VA = "0x1849C8A90")]
	public void PAHGPGOBLOG(TClaimant DIMNBLIIFEB, TNode NJEDJGLJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x49C75F0", Offset = "0x49C69F0", VA = "0x1849C75F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x49C8670", Offset = "0x49C7A70", VA = "0x1849C8670")]
	private void NBHIILIKOMJ(TClaimant DIMNBLIIFEB, TNode HLCEBKJKOKD, TNode NJEDJGLJDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x49C8150", Offset = "0x49C7550", VA = "0x1849C8150")]
	private int JKKFAOEONNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x49C8740", Offset = "0x49C7B40", VA = "0x1849C8740")]
	private void NKLPBHJOHEB(TClaimant DIMNBLIIFEB, TNode MHCJEACPLEG, TNode FKGHPCFGFJE, int MDBOOCNPIBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x49C72E0", Offset = "0x49C66E0", VA = "0x1849C72E0")]
	private void AIJCHCDBAJJ(NOLCDBENBPB FFGBOGCDFGK, OFAGCFKONIE INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x49C81C0", Offset = "0x49C75C0", VA = "0x1849C81C0")]
	private void KGLIDGIAKHL(TClaimant DIMNBLIIFEB, TNode MHCJEACPLEG, TNode FKGHPCFGFJE, int MDBOOCNPIBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x49C74C0", Offset = "0x49C68C0", VA = "0x1849C74C0")]
	private void DFNNNIFGOBN(NOLCDBENBPB FFGBOGCDFGK, TNode BLGGFHHEDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x49C78C0", Offset = "0x49C6CC0", VA = "0x1849C78C0")]
	private void FHMFIJMMJLI(NOLCDBENBPB FFGBOGCDFGK, OFAGCFKONIE INAPFKLHCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x49C7B10", Offset = "0x49C6F10", VA = "0x1849C7B10")]
	private void HBPPEGAPCCK(OFAGCFKONIE INAPFKLHCFN, bool LMGFPBGEHIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x49C7DE0", Offset = "0x49C71E0", VA = "0x1849C7DE0")]
	private void IENFLAKODGG(OFAGCFKONIE INAPFKLHCFN, TNode BBFFOKPDHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x49C7A20", Offset = "0x49C6E20", VA = "0x1849C7A20")]
	[IteratorStateMachine(typeof(IADDFIIACED<, >.DFNOMGIKOJP))]
	private IEnumerable<TNode> GKPHKFPABNC(TNode MHCJEACPLEG, TNode FKGHPCFGFJE, bool DMALALHBOOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x49C73B0", Offset = "0x49C67B0", VA = "0x1849C73B0")]
	private OFAGCFKONIE BNGANNPELCE(TNode BLGGFHHEDNC, TNode KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x49C7C60", Offset = "0x49C7060", VA = "0x1849C7C60")]
	private OFAGCFKONIE IEKOKIJOAGG(TNode BLGGFHHEDNC, TNode KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x49C84B0", Offset = "0x49C78B0", VA = "0x1849C84B0")]
	private void LJGHGBJNDKO(OFAGCFKONIE INAPFKLHCFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PJEGKALNPFE<T> : IEnumerable<PJEGKALNPFE<T>.EOINJMMPHOL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct EOINJMMPHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T FFOEEMKIKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int CJFNAFNJJLB;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class FALODCNPKKL : IEnumerator<EOINJMMPHOL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PJEGKALNPFE<T> IMOLDFICHHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int CJFNAFNJJLB;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x42F0410", Offset = "0x42EF810", VA = "0x1842F0410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EOINJMMPHOL JKNLEFEANEI
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x46EBB60", Offset = "0x46EAF60", VA = "0x1846EBB60", Slot = "4")]
			get
			{
				return default(EOINJMMPHOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x46EBA70", Offset = "0x46EAE70", VA = "0x1846EBA70")]
		public FALODCNPKKL(PJEGKALNPFE<T> IMOLDFICHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x46EB970", Offset = "0x46EAD70", VA = "0x1846EB970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x434FF60", Offset = "0x434F360", VA = "0x18434FF60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1053D90", Offset = "0x1053190", VA = "0x181053D90", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct EJCPBKLMLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool JFOBOLNIPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T FFOEEMKIKJO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int KMLIDEPMLCN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OJNLGJKINNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private EJCPBKLMLME[] FLCIPACJAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int LJJOJPHLNKI;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int IHHMIFJCELF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xC69A20", Offset = "0xC68E20", VA = "0x180C69A20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xE46E60", Offset = "0xE46260", VA = "0x180E46E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B50", Offset = "0x3E97F50", VA = "0x183E98B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x52E8D90", Offset = "0x52E8190", VA = "0x1852E8D90")]
	public PJEGKALNPFE(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x52E8970", Offset = "0x52E7D70", VA = "0x1852E8970")]
	public PJEGKALNPFE(EOINJMMPHOL[] KEOKEOEPADF, bool DPCDAPKIAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x52E7790", Offset = "0x52E6B90", VA = "0x1852E7790")]
	public int EFMAMFAINCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x52E7EC0", Offset = "0x52E72C0", VA = "0x1852E7EC0")]
	private int LLMPHCAMOMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x52E83E0", Offset = "0x52E77E0", VA = "0x1852E83E0", Slot = "6")]
	protected virtual uint NODBEKNMJCK(uint FJJIBEAAGGP, T FFOEEMKIKJO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x52E7850", Offset = "0x52E6C50", VA = "0x1852E7850")]
	public bool KADJIPIGNIG(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x52E7690", Offset = "0x52E6A90", VA = "0x1852E7690")]
	public int AMFLNKOGMNI(T FFOEEMKIKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x52E8340", Offset = "0x52E7740", VA = "0x1852E8340")]
	public T MLACMEICEMO(int CJFNAFNJJLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x52E7910", Offset = "0x52E6D10", VA = "0x1852E7910")]
	public bool KHHMKEEJKGJ(T FFOEEMKIKJO, bool JNLBGJFJKEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x52E7C10", Offset = "0x52E7010", VA = "0x1852E7C10")]
	public bool KHHMKEEJKGJ(T FFOEEMKIKJO, int CJFNAFNJJLB, bool JNLBGJFJKEB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x52E8400", Offset = "0x52E7800", VA = "0x1852E8400")]
	private int OCDDGOEOAFK(int GNPKFMEIDNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x52E84A0", Offset = "0x52E78A0", VA = "0x1852E84A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x52E84A0", Offset = "0x52E78A0", VA = "0x1852E84A0", Slot = "4")]
	private IEnumerator<EOINJMMPHOL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class MAEKECGNICD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> LHNFDMCLNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> PIFDACANOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int HJLCKKMBJOD;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5012390", Offset = "0x5011790", VA = "0x185012390")]
	public static MAEKECGNICD<T> PKGLILPKCKL(int HDAIOJEADNO = 0, int HJLCKKMBJOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5012480", Offset = "0x5011880", VA = "0x185012480")]
	public static MAEKECGNICD<T> PPADHNPKEEP(int HDAIOJEADNO = 0, int HJLCKKMBJOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5012570", Offset = "0x5011970", VA = "0x185012570")]
	public MAEKECGNICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x50125C0", Offset = "0x50119C0", VA = "0x1850125C0")]
	public MAEKECGNICD(int HDAIOJEADNO, int HJLCKKMBJOD = int.MaxValue, bool MNFGFMNHHAF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5012080", Offset = "0x5011480", VA = "0x185012080")]
	public T GKNBKKNIPGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5011FA0", Offset = "0x50113A0", VA = "0x185011FA0")]
	public void FEMKONHLAGL(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5012290", Offset = "0x5011690", VA = "0x185012290")]
	private void KCIOHMKNAKK(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5012250", Offset = "0x5011650", VA = "0x185012250")]
	private void HHEBOIDCBLJ(T FFOEEMKIKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5011E10", Offset = "0x5011210", VA = "0x185011E10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5011C20", Offset = "0x5011020", VA = "0x185011C20")]
	private void CFADOGINOMI(IEnumerable<T> JGMAGBDHLIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BJEDLBDJLJD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> JLLDPNEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T LGHJNJMPFJL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T HICMJGNAKOC
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x993210", Offset = "0x992610", VA = "0x180993210", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5F42B30", Offset = "0x5F41F30", VA = "0x185F42B30")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4BED1E0", Offset = "0x4BEC5E0", VA = "0x184BED1E0")]
	public bool GOGJPLAFFMK(int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5F42650", Offset = "0x5F41A50", VA = "0x185F42650")]
	public T GFLLIGKNOFJ(int HGOLMEKOOJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5F42460", Offset = "0x5F41860", VA = "0x185F42460")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5F42400", Offset = "0x5F41800", VA = "0x185F42400")]
	public bool BGPIDOLLEKE(int PKKOAIHLPOK, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5F42BD0", Offset = "0x5F41FD0", VA = "0x185F42BD0")]
	public BJEDLBDJLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class JDGCAPCOLKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct LOAKKBCIOFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T HDKOPKMNJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int KCOBLCMJBKO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<LOAKKBCIOFD> HHOLFJLOEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T JIKNOOCDKPG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B50", Offset = "0x3E97F50", VA = "0x183E98B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF9A0", Offset = "0x4BDEDA0", VA = "0x184BDF9A0")]
	public bool JOEMDCADNHJ(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF8F0", Offset = "0x4BDECF0", VA = "0x184BDF8F0")]
	public void JJBKLNLGAIJ(T FFOEEMKIKJO, int PKKOAIHLPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF620", Offset = "0x4BDEA20", VA = "0x184BDF620")]
	public bool JEBJOEBLLEI(T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF100", Offset = "0x4BDE500", VA = "0x184BDF100")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFD90", Offset = "0x4BDF190", VA = "0x184BDFD90")]
	public T NBAGDHBBMCG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4BDF320", Offset = "0x4BDE720", VA = "0x184BDF320")]
	protected void GNAEPOOJIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4BDFEC0", Offset = "0x4BDF2C0", VA = "0x184BDFEC0")]
	public JDGCAPCOLKP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x784D040", Offset = "0x784C440", VA = "0x18784D040")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x784D310", Offset = "0x784C710", VA = "0x18784D310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x784D220", Offset = "0x784C620", VA = "0x18784D220")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x784CF90", Offset = "0x784C390", VA = "0x18784CF90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x784D260", Offset = "0x784C660", VA = "0x18784D260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x784D170", Offset = "0x784C570", VA = "0x18784D170")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x784CF00", Offset = "0x784C300", VA = "0x18784CF00")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x54F1B70", Offset = "0x54F0F70", VA = "0x1854F1B70", Slot = "4")]
		public virtual T NOJEAIIHJKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GIPJKJOHGOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, HLKDFEAAGHL> EPNOLAOCCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly MAEKECGNICD<HLKDFEAAGHL> PMBHIEBEGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool DEGLOHDFKJN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HLKDFEAAGHL BJCGPEEMGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x994500", Offset = "0x993900", VA = "0x180994500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 BLEEENGKIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x149C770", Offset = "0x149BB70", VA = "0x18149C770")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xBCC2A0", Offset = "0xBCB6A0", VA = "0x180BCC2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 IHJJFDFCDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC09330", Offset = "0xC08730", VA = "0x180C09330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 PCKNMKPEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x784A260", Offset = "0x7849660", VA = "0x18784A260")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x9943B0", Offset = "0x9937B0", VA = "0x1809943B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int GPMBEGAAOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x99A290", Offset = "0x999690", VA = "0x18099A290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x99A280", Offset = "0x999680", VA = "0x18099A280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x784B120", Offset = "0x784A520", VA = "0x18784B120")]
	public GIPJKJOHGOJ(Bounds FCNAOLFGABF, Vector2[] IIENOAADPPM, int JAOKLDDAOCK, byte GNPKFMEIDNL, float FOGNJLJNAAM = 0f, [Optional] MAEKECGNICD<HLKDFEAAGHL> PMBHIEBEGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x784A840", Offset = "0x7849C40", VA = "0x18784A840")]
	public void MKDDMOFNGEH(Bounds FCNAOLFGABF, Vector2[] IIENOAADPPM, int JAOKLDDAOCK, byte GNPKFMEIDNL, float FOGNJLJNAAM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x784A7E0", Offset = "0x7849BE0", VA = "0x18784A7E0")]
	public HLKDFEAAGHL LOACJMMNNIL(byte CJFNAFNJJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x784A190", Offset = "0x7849590", VA = "0x18784A190")]
	public void BEACFMJMIPM(Vector3 INHMOEHIHAJ, float LMIAKEKJLAE, float CJOHBAOHBNO, List<byte> CBCGNOJNLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x784A170", Offset = "0x7849570", VA = "0x18784A170")]
	public void AMLBAKKIAHO(HLKDFEAAGHL.EBNOBKKBKIG MBIOPMNCMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x784A700", Offset = "0x7849B00", VA = "0x18784A700")]
	public static int KLOAJNPMLEL(Vector2[] IIENOAADPPM, int JAOKLDDAOCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x784ACD0", Offset = "0x784A0D0", VA = "0x18784ACD0")]
	private HLKDFEAAGHL NLFDIKBALII(byte CJFNAFNJJLB, HLKDFEAAGHL.OAKPGKHPPIJ KIDCBFDJAGE, HLKDFEAAGHL KLDFHLFOOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x784A280", Offset = "0x7849680", VA = "0x18784A280")]
	private void DONOIJMGDGE(HLKDFEAAGHL KLDFHLFOOFN, Vector2[] IIENOAADPPM, int FNEKGGKBJKD, int KCDCHBKIAOH, int PAAEEECMFDJ, int BEBAIMOENDE, float FOGNJLJNAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x784AF00", Offset = "0x784A300", VA = "0x18784AF00")]
	private void POPKDBMJAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x784A640", Offset = "0x7849A40", VA = "0x18784A640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x784A6A0", Offset = "0x7849AA0", VA = "0x18784A6A0", Slot = "1")]
	~GIPJKJOHGOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HLKDFEAAGHL
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum OAKPGKHPPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum EBNOBKKBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte GEEBDAOOGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 MOBLDDDLJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 BFPJLGPCCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 CMCKKLLJEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 ALBCIAIGKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public OAKPGKHPPIJ CFNCDKOFGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HLKDFEAAGHL HBBFFDLJGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<HLKDFEAAGHL> EOKIIEEEJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool BFBEDIFAFLM;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x784B730", Offset = "0x784AB30", VA = "0x18784B730")]
	public HLKDFEAAGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x784B5F0", Offset = "0x784A9F0", VA = "0x18784B5F0")]
	public void OEHIFBKDANM(HLKDFEAAGHL MKPPIPAJFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
	public void AMLBAKKIAHO(int NCFAMHMJGPN, EBNOBKKBKIG MBIOPMNCMAJ, int DEBJGENBPIA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x784B2A0", Offset = "0x784A6A0", VA = "0x18784B2A0")]
	public void BEACFMJMIPM(List<byte> CBCGNOJNLCK, Vector3 INHMOEHIHAJ, float LMIAKEKJLAE, float CJOHBAOHBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x784B5C0", Offset = "0x784A9C0", VA = "0x18784B5C0")]
	public bool KKACCBDFIPJ(Vector3 PFALLGAIEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x784B590", Offset = "0x784A990", VA = "0x18784B590")]
	public bool IJOLKAENOFH(Vector3 PFALLGAIEAE, float GIEPCOMBBEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x784B500", Offset = "0x784A900", VA = "0x18784B500")]
	public void GDCNGOALEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface ININABGLLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache ABOPFABMBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct DODFNDEIIFO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> CEFIHBLEFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool FODLKBCCJDD;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1692140", Offset = "0x1691540", VA = "0x181692140")]
			public DODFNDEIIFO(List<Component> CEFIHBLEFNG, bool FODLKBCCJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x6695B30", Offset = "0x6694F30", VA = "0x186695B30")]
			public IAMKIHMAPMH<T> DBEEDGEHMMA()
			{
				return default(IAMKIHMAPMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x6695B90", Offset = "0x6694F90", VA = "0x186695B90", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x6695B90", Offset = "0x6694F90", VA = "0x186695B90", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct IAMKIHMAPMH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> CEFIHBLEFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool FODLKBCCJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int CJFNAFNJJLB;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T JKNLEFEANEI
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x49CA0F0", Offset = "0x49C94F0", VA = "0x1849CA0F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x49CA080", Offset = "0x49C9480", VA = "0x1849CA080", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x49CA0C0", Offset = "0x49C94C0", VA = "0x1849CA0C0")]
			public IAMKIHMAPMH(List<Component> CEFIHBLEFNG, bool FODLKBCCJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x49C9FC0", Offset = "0x49C93C0", VA = "0x1849C9FC0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x49C9FD0", Offset = "0x49C93D0", VA = "0x1849C9FD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x433F5D0", Offset = "0x433E9D0", VA = "0x18433F5D0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x784ED40", Offset = "0x784E140", VA = "0x18784ED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x784E730", Offset = "0x784DB30", VA = "0x18784E730")]
		private void GDCNGOALEGL(GameObject PLAPLCBPJGM, bool HLPBIKLHEBD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x784E6A0", Offset = "0x784DAA0", VA = "0x18784E6A0")]
		public static void GDCNGOALEGL(GameObject PLAPLCBPJGM, ToolHierarchyCache OEEONBHNECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x784E910", Offset = "0x784DD10", VA = "0x18784E910")]
		public void JMFBBFMHGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3993EB0", Offset = "0x39932B0", VA = "0x183993EB0")]
		public void GHBILAMAGEG<T>(Action<T> IOPCFKOHPBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3993E10", Offset = "0x3993210", VA = "0x183993E10")]
		public T BHCANJCCIFF<T>(bool FODLKBCCJDD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x39940F0", Offset = "0x39934F0", VA = "0x1839940F0")]
		public DODFNDEIIFO<T> JCJNJCDHNJL<T>(bool FODLKBCCJDD = false) where T : class
		{
			return default(DODFNDEIIFO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x784E920", Offset = "0x784DD20", VA = "0x18784E920")]
		public List<Component> OPENLKHMMDK(Type HAFNBBNOLPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x784E620", Offset = "0x784DA20", VA = "0x18784E620", Slot = "4")]
		public bool Equals(ToolHierarchyCache MEAMPLHPPKP, ToolHierarchyCache KDELALKKKOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x784E8A0", Offset = "0x784DCA0", VA = "0x18784E8A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BLFGIKOAKOL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class CEBDBMIPKGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int HDAIOJEADNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GPGGADNCIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> KLIMJMOCIDN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4706DD0", Offset = "0x47061D0", VA = "0x184706DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T HNICEFLLFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x63074F0", Offset = "0x63068F0", VA = "0x1863074F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T PECHBGPDAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63073E0", Offset = "0x63067E0", VA = "0x1863073E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T NAECMHEKOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6307340", Offset = "0x6306740", VA = "0x186307340")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6307A50", Offset = "0x6306E50", VA = "0x186307A50")]
	public CEBDBMIPKGF(int HDAIOJEADNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63077F0", Offset = "0x6306BF0", VA = "0x1863077F0")]
	public void JJBKLNLGAIJ(T FNMNNKBIPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6307270", Offset = "0x6306670", VA = "0x186307270")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x6307180", Offset = "0x6306580", VA = "0x186307180")]
	public void BGGANAPDHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x63079F0", Offset = "0x6306DF0", VA = "0x1863079F0")]
	public void MCCJACAAFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6307170", Offset = "0x6306570", VA = "0x186307170")]
	public void AHOJIPONMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6307960", Offset = "0x6306D60", VA = "0x186307960")]
	public List<T> LHLCCBBLLDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class EOEMODHNBOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct NNNBMCLIIEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int KCOBLCMJBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T HDKOPKMNJCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, NNNBMCLIIEE> JLLDPNEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> BDBNFBEJAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T LGHJNJMPFJL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T HICMJGNAKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xC71960", Offset = "0xC70D60", VA = "0x180C71960", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x42E2270", Offset = "0x42E1670", VA = "0x1842E2270", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool PKMGEMMGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x42E18B0", Offset = "0x42E0CB0", VA = "0x1842E18B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object DOLHFECNPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x99E210", Offset = "0x99D610", VA = "0x18099E210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x42E2170", Offset = "0x42E1570", VA = "0x1842E2170")]
	public bool JHAAOHPGICL(T FFOEEMKIKJO, object HHGPJKKLNIG, int PKKOAIHLPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x42E1910", Offset = "0x42E0D10", VA = "0x1842E1910")]
	public bool GOGJPLAFFMK(object HHGPJKKLNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x42DF6E0", Offset = "0x42DEAE0", VA = "0x1842DF6E0")]
	public bool BGPIDOLLEKE(object HHGPJKKLNIG, [Out] T FFOEEMKIKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x42DF8B0", Offset = "0x42DECB0", VA = "0x1842DF8B0")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x42E0540", Offset = "0x42DF940", VA = "0x1842E0540")]
	private bool CMPEKILFMCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x42E22E0", Offset = "0x42E16E0", VA = "0x1842E22E0")]
	public EOEMODHNBOJ()
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
