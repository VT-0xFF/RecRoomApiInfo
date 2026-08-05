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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x694E4B0", Offset = "0x694D4B0", VA = "0x18694E4B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JFIGCELNGLH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15C3B30", Offset = "0x15C2B30", VA = "0x1815C3B30")]
	public JFIGCELNGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, JODLHPFGCKF, INAIILMGFEG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NPOAPJJLLAJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x939730", Offset = "0x938730", VA = "0x180939730")]
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
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6950580", Offset = "0x694F580", VA = "0x186950580")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6950540", Offset = "0x694F540", VA = "0x186950540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69505C0", Offset = "0x694F5C0", VA = "0x1869505C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6950770", Offset = "0x694F770", VA = "0x186950770")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69506E0", Offset = "0x694F6E0", VA = "0x1869506E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99AE70", Offset = "0x999E70", VA = "0x18099AE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99AE60", Offset = "0x999E60", VA = "0x18099AE60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6950500", Offset = "0x694F500", VA = "0x186950500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6950650", Offset = "0x694F650", VA = "0x186950650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x694FF70", Offset = "0x694EF70", VA = "0x18694FF70")]
	public void CopyBounds(SavedExtents ACBLPNJDJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6950450", Offset = "0x694F450", VA = "0x186950450")]
	public void SetLocalSpaceBounds(Bounds GIOPHKAJPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC84D10", Offset = "0xC83D10", VA = "0x180C84D10")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6950440", Offset = "0x694F440", VA = "0x186950440")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6950060", Offset = "0x694F060", VA = "0x186950060")]
	private void NNMHELCCHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6950220", Offset = "0x694F220", VA = "0x186950220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x694F900", Offset = "0x694E900", VA = "0x18694F900")]
	public static void CalculateLocalBoundsFor(GameObject IDHOMJBMFPB, [Out] Bounds GIOPHKAJPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x694FFA0", Offset = "0x694EFA0", VA = "0x18694FFA0")]
	private static void DMJEOEMIGGP(Bounds JCHFDOINNOA, Color MHIEIJBIEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6950470", Offset = "0x694F470", VA = "0x186950470")]
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
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10B5320", Offset = "0x10B4320", VA = "0x1810B5320")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49A4D30", Offset = "0x49A3D30", VA = "0x1849A4D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public virtual void GBPJALHKIAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
	[JFIGCELNGLH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49A48B0", Offset = "0x49A38B0", VA = "0x1849A48B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49A30D0", Offset = "0x49A20D0", VA = "0x1849A30D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49A4C30", Offset = "0x49A3C30", VA = "0x1849A4C30")]
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
	private sealed class PPIPGAIBBMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public PPIPGAIBBMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x47CDF40", Offset = "0x47CCF40", VA = "0x1847CDF40")]
		internal int CONEFCHHKCP(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[JFIGCELNGLH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38BC840", Offset = "0x38BB840", VA = "0x1838BC840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x38BC8A0", Offset = "0x38BB8A0", VA = "0x1838BC8A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38BC720", Offset = "0x38BB720", VA = "0x1838BC720", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GMFCIHEFPPO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x38BC7E0", Offset = "0x38BB7E0", VA = "0x1838BC7E0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38BC5D0", Offset = "0x38BB5D0", VA = "0x1838BC5D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x38BC290", Offset = "0x38BB290", VA = "0x1838BC290", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38BB6B0", Offset = "0x38BA6B0", VA = "0x1838BB6B0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38BB550", Offset = "0x38BA550", VA = "0x1838BB550", Slot = "14")]
	protected virtual string COICPGOPEJF(TKeyVal CNFPLGGBHOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38BB5B0", Offset = "0x38BA5B0", VA = "0x1838BB5B0", Slot = "4")]
	public bool ContainsKey(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38BC450", Offset = "0x38BB450", VA = "0x1838BC450", Slot = "5")]
	public bool TryGetValue(TKey GMFCIHEFPPO, [Out] TVal JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38BB610", Offset = "0x38BA610", VA = "0x1838BB610", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38BB610", Offset = "0x38BA610", VA = "0x1838BB610", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x38BC4B0", Offset = "0x38BB4B0", VA = "0x1838BC4B0")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D1BC50", Offset = "0x3D1AC50", VA = "0x183D1BC50")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[JFIGCELNGLH]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49A5EB0", Offset = "0x49A4EB0", VA = "0x1849A5EB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49A54C0", Offset = "0x49A44C0", VA = "0x1849A54C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x49A4C30", Offset = "0x49A3C30", VA = "0x1849A4C30")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FJLOCNOFAHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LNHMKDCHFME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float FNEMAOGEBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T JMEAFIDIDGF;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LNHMKDCHFME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class ONPCCDDFDBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ONPCCDDFDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x46FA0A0", Offset = "0x46F90A0", VA = "0x1846FA0A0")]
		internal bool ACNBEOOILJE(LNHMKDCHFME sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float EBBKIOFNFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float FKMEDJMDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<LNHMKDCHFME> NNIIEFMINKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IDPKEELFKKI<LNHMKDCHFME> FNBBAGDOJFL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DDNNFOHEEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3C41A80", Offset = "0x3C40A80", VA = "0x183C41A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C42280", Offset = "0x3C41280", VA = "0x183C42280")]
	public FJLOCNOFAHD(float BPMLGDEEJFA, float MCJNIAGBMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C416A0", Offset = "0x3C406A0", VA = "0x183C416A0")]
	public bool BIOICEPJLCF(float PJONDALPKNN, T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3C41AF0", Offset = "0x3C40AF0", VA = "0x183C41AF0")]
	public IEnumerable<T> OENOCEANIMK(float PJONDALPKNN, [Optional] float? EPOBIMGFPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C421D0", Offset = "0x3C411D0", VA = "0x183C421D0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3C41870", Offset = "0x3C40870", VA = "0x183C41870")]
	private void IBBKCOCBHAM(float PJONDALPKNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OJAALPICLBN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EPBHGGEJMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T JMEAFIDIDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float HOGCJKOMKJI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float HDEPPHCOBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> PFKCDBGKECM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int GKLMDJHAADL = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private EPBHGGEJMDH[] IKONNGGNFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int FDACANENLAD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float BKNCHEDHHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA80EC0", Offset = "0xA7FEC0", VA = "0x180A80EC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA63E0", Offset = "0xAA53E0", VA = "0x180AA63E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x46F3970", Offset = "0x46F2970", VA = "0x1846F3970")]
	public OJAALPICLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x46F3840", Offset = "0x46F2840", VA = "0x1846F3840")]
	public OJAALPICLBN(int GHACOABIHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x46F30A0", Offset = "0x46F20A0", VA = "0x1846F30A0")]
	public void GKAGDNHKNII(float PJONDALPKNN, T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x46F36F0", Offset = "0x46F26F0", VA = "0x1846F36F0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x46F2A40", Offset = "0x46F1A40", VA = "0x1846F2A40")]
	public bool AJIDGBCMIDF(float NPGLKCPEHKE, float KCGJJLJBGPA, [Out] T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x46F2CC0", Offset = "0x46F1CC0", VA = "0x1846F2CC0")]
	public bool EAGBNCLFIBO(float NPGLKCPEHKE, float KCGJJLJBGPA, [Out] T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x46F32F0", Offset = "0x46F22F0", VA = "0x1846F32F0")]
	public void PBLKOJPNGFA(float NPGLKCPEHKE, float KCGJJLJBGPA, List<T> EPDCHNAKJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x46F2C90", Offset = "0x46F1C90", VA = "0x1846F2C90")]
	private int CJIIPCOJMOH(int LFGIBNOJODB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x46F32A0", Offset = "0x46F22A0", VA = "0x1846F32A0")]
	private void JNAMGIMAAGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CMEJDPHBDKK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NIOEAOFFDMA(T JJCEIJMGOAB, float IGKMAMABJBH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T PNPLCCGFHHE(T PNODNPKGJKB, T JHNJJGDAEGF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BEBLGGDBNCC(T PNODNPKGJKB, T JHNJJGDAEGF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NPAJLKJNHKJ : OJAALPICLBN<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x861CF0", Offset = "0x860CF0", VA = "0x180861CF0", Slot = "4")]
	protected override Vector3 CMEJDPHBDKK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x694E3C0", Offset = "0x694D3C0", VA = "0x18694E3C0", Slot = "5")]
	protected override Vector3 NIOEAOFFDMA(Vector3 JJCEIJMGOAB, float IGKMAMABJBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x694E400", Offset = "0x694D400", VA = "0x18694E400", Slot = "6")]
	protected override Vector3 PNPLCCGFHHE(Vector3 PNODNPKGJKB, Vector3 JHNJJGDAEGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x694E340", Offset = "0x694D340", VA = "0x18694E340", Slot = "7")]
	protected override Vector3 BEBLGGDBNCC(Vector3 PNODNPKGJKB, Vector3 JHNJJGDAEGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x694E450", Offset = "0x694D450", VA = "0x18694E450")]
	public NPAJLKJNHKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ADKJAEJJBIO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3266200", Offset = "0x3265200", VA = "0x183266200")]
	public static MFCGGDPIIAM<T1, T2> EAPGIKBOING<T1, T2>(T1 KHKJOJILIJH, T2 CCIPBGCPDAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3266290", Offset = "0x3265290", VA = "0x183266290")]
	public static OPHGEBCHKGH<T1, T2, T3> EAPGIKBOING<T1, T2, T3>(T1 KHKJOJILIJH, T2 CCIPBGCPDAI, T3 GHKHMEAJMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x45B2FF0", Offset = "0x45B1FF0", VA = "0x1845B2FF0")]
	internal static int GGHFGOBLPBI(int EEMPLKFLCAH, int FJANJCAAKHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1060", Offset = "0x5CF0060", VA = "0x185CF1060")]
	internal static int GGHFGOBLPBI(int EEMPLKFLCAH, int FJANJCAAKHJ, int JNCOGMCNPNP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MFCGGDPIIAM<T1, T2> : IComparable<MFCGGDPIIAM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 FGMJIOPPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 JDEAOBCMMNJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x44E2850", Offset = "0x44E1850", VA = "0x1844E2850")]
	public MFCGGDPIIAM(T1 KHKJOJILIJH, T2 CCIPBGCPDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x44E0FF0", Offset = "0x44DFFF0", VA = "0x1844E0FF0", Slot = "4")]
	public int CompareTo(MFCGGDPIIAM<T1, T2> ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x44E1350", Offset = "0x44E0350", VA = "0x1844E1350", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x44E1AF0", Offset = "0x44E0AF0", VA = "0x1844E1AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x44E26F0", Offset = "0x44E16F0", VA = "0x1844E26F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OPHGEBCHKGH<T1, T2, T3> : IComparable<OPHGEBCHKGH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 FGMJIOPPBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 JDEAOBCMMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 IEKIOOEBOKI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4702770", Offset = "0x4701770", VA = "0x184702770")]
	public OPHGEBCHKGH(T1 KHKJOJILIJH, T2 CCIPBGCPDAI, T3 GHKHMEAJMFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4701FA0", Offset = "0x4700FA0", VA = "0x184701FA0", Slot = "4")]
	public int CompareTo(OPHGEBCHKGH<T1, T2, T3> ACBLPNJDJBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x47020F0", Offset = "0x47010F0", VA = "0x1847020F0", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4702410", Offset = "0x4701410", VA = "0x184702410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x47025C0", Offset = "0x47015C0", VA = "0x1847025C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T JMEAFIDIDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x23552E0", Offset = "0x23542E0", VA = "0x1823552E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23552F0", Offset = "0x23542F0", VA = "0x1823552F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float KOPGIPNBDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99AE30", Offset = "0x999E30", VA = "0x18099AE30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAA90", Offset = "0x4BE9A90", VA = "0x184BEAA90")]
	public T BKAMHNLEBIB(float IGKMAMABJBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAF60", Offset = "0x4BE9F60", VA = "0x184BEAF60")]
	public T IFKADJHHBDB(float IGKMAMABJBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AKGNAHNONKJ(T PNODNPKGJKB, T JHNJJGDAEGF, float IGKMAMABJBH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x694DFC0", Offset = "0x694CFC0", VA = "0x18694DFC0", Slot = "4")]
	protected override float AKGNAHNONKJ(float PNODNPKGJKB, float JHNJJGDAEGF, float IGKMAMABJBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x694E000", Offset = "0x694D000", VA = "0x18694E000")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xF5A4D0", Offset = "0xF594D0", VA = "0x180F5A4D0", Slot = "4")]
	protected override Vector3 AKGNAHNONKJ(Vector3 PNODNPKGJKB, Vector3 JHNJJGDAEGF, float IGKMAMABJBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6951580", Offset = "0x6950580", VA = "0x186951580")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x694DD50", Offset = "0x694CD50", VA = "0x18694DD50", Slot = "4")]
	protected override Color AKGNAHNONKJ(Color PNODNPKGJKB, Color JHNJJGDAEGF, float IGKMAMABJBH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x694DE10", Offset = "0x694CE10", VA = "0x18694DE10")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CJLGBHCILAM : GHNLIJONBBO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x694DD00", Offset = "0x694CD00", VA = "0x18694DD00")]
	public CJLGBHCILAM(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x694DC90", Offset = "0x694CC90", VA = "0x18694DC90", Slot = "6")]
	protected override uint MNBAIKEMHAI(uint NPOAPJJLLAJ, string JJCEIJMGOAB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PPJPKJNAKHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable PNNELGGLBHA;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public PPJPKJNAKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct NICNKIPAHPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GFOJBCGMEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int LOAODELNGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int CIOPDAIBOPG;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4112100", Offset = "0x4111100", VA = "0x184112100")]
	private NICNKIPAHPO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ADCPADHJBMA, int JBJOBKJDLLK, int PCIJBABFLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x45EAC20", Offset = "0x45E9C20", VA = "0x1845EAC20")]
	public static NICNKIPAHPO<T> GAKCNKPJGEK()
	{
		return default(NICNKIPAHPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x45E8F70", Offset = "0x45E7F70", VA = "0x1845E8F70")]
	public (int, int, Task<T>) BIHINHPIKPD(int GCCAFDBPHMC, [Optional] CancellationToken LABHBAHABKB, double GHCGFNCODKM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x45EA4A0", Offset = "0x45E94A0", VA = "0x1845EA4A0")]
	public void FFBGLGHKMKH(int GCCAFDBPHMC, int PCIJBABFLNO, [In] T KNFGDDANCCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class AOENFPLLMFH
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x694B890", Offset = "0x694A890", VA = "0x18694B890")]
	public static NICNKIPAHPO<OKOMLKNINNF> GAKCNKPJGEK()
	{
		return default(NICNKIPAHPO<OKOMLKNINNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x694B810", Offset = "0x694A810", VA = "0x18694B810")]
	public static void FFBGLGHKMKH([In] this NICNKIPAHPO<OKOMLKNINNF> KALCJEIICGB, int GCCAFDBPHMC, int PCIJBABFLNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class MEOKDPIPNEF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> CCCCEPKGMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> GCKJOMPCMDD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x35E3D10", Offset = "0x35E2D10", VA = "0x1835E3D10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KEMHBPIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> BOBINNLNLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AF70", Offset = "0x3C89F70", VA = "0x183C8AF70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> FBFLONJFPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3D34BC0", Offset = "0x3D33BC0", VA = "0x183D34BC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x44E0750", Offset = "0x44DF750", VA = "0x1844E0750", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x44E07B0", Offset = "0x44DF7B0", VA = "0x1844E07B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x44DFA30", Offset = "0x44DEA30", VA = "0x1844DFA30")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x44DFBC0", Offset = "0x44DEBC0", VA = "0x1844DFBC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x44E0530", Offset = "0x44DF530", VA = "0x1844E0530", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x44DFB30", Offset = "0x44DEB30", VA = "0x1844DFB30", Slot = "9")]
	public void Add(TKey GMFCIHEFPPO, TVal JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x44DFAE0", Offset = "0x44DEAE0", VA = "0x1844DFAE0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3D35300", Offset = "0x3D34300", VA = "0x183D35300", Slot = "8")]
	public bool ContainsKey(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x44DFCA0", Offset = "0x44DECA0", VA = "0x1844DFCA0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x44E04B0", Offset = "0x44DF4B0", VA = "0x1844E04B0", Slot = "10")]
	public bool Remove(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x44E0470", Offset = "0x44DF470", VA = "0x1844E0470", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x44E05D0", Offset = "0x44DF5D0", VA = "0x1844E05D0", Slot = "11")]
	public bool TryGetValue(TKey GMFCIHEFPPO, [Out] TVal JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x44DFD60", Offset = "0x44DED60", VA = "0x1844DFD60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x44DFCE0", Offset = "0x44DECE0", VA = "0x1844DFCE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IKONNGGNFPH, int MNPIBEICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44DFE60", Offset = "0x44DEE60", VA = "0x1844DFE60")]
	public bool HNEILIJEPGH(TVal GMFCIHEFPPO, [Out] TKey JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44DFEC0", Offset = "0x44DEEC0", VA = "0x1844DFEC0")]
	private void ICNEMDNOIIM(TKey GMFCIHEFPPO, TVal AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x44E0080", Offset = "0x44DF080", VA = "0x1844E0080")]
	private void NJDKKCLKIFF(TKey GMFCIHEFPPO, TVal AAINAOCHJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x44E0240", Offset = "0x44DF240", VA = "0x1844E0240")]
	private bool NKLFDDHDIPC(TKey GMFCIHEFPPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44E0630", Offset = "0x44DF630", VA = "0x1844E0630")]
	public MEOKDPIPNEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class CBEIOMLKGCL<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private CBEIOMLKGCL<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3908320", Offset = "0x3907320", VA = "0x183908320", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x390F690", Offset = "0x390E690", VA = "0x18390F690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3910910", Offset = "0x390F910", VA = "0x183910910")]
		public Enumerator(CBEIOMLKGCL<T> EPDCHNAKJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x390D300", Offset = "0x390C300", VA = "0x18390D300", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x390EB10", Offset = "0x390DB10", VA = "0x18390EB10", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x390D190", Offset = "0x390C190", VA = "0x18390D190")]
		private void IKCAIIIDNIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] HBBBNEHNIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int EFHNBALPFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int IFCLFELEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int FFOAGBHJNBO;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5185AB0", Offset = "0x5184AB0", VA = "0x185185AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5183E20", Offset = "0x5182E20", VA = "0x185183E20")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5185050", Offset = "0x5184050", VA = "0x185185050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5185DF0", Offset = "0x5184DF0", VA = "0x185185DF0")]
	public CBEIOMLKGCL(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5184A70", Offset = "0x5183A70", VA = "0x185184A70")]
	public void GKAGDNHKNII(T IGKMAMABJBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5185AF0", Offset = "0x5184AF0", VA = "0x185185AF0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x51849A0", Offset = "0x51839A0", VA = "0x1851849A0")]
	public void FLAGKDEBPCO(int DOPPKGNLPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5184720", Offset = "0x5183720", VA = "0x185184720")]
	public void CCCKDJJGLNN(T[] IKONNGGNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5184930", Offset = "0x5183930", VA = "0x185184930")]
	public Enumerator EAJKDCOBAGF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5185C50", Offset = "0x5184C50", VA = "0x185185C50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5185C50", Offset = "0x5184C50", VA = "0x185185C50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x51853F0", Offset = "0x51843F0", VA = "0x1851853F0")]
	private int OBIECBHBOEI(int HCALFJOJKJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x51853C0", Offset = "0x51843C0", VA = "0x1851853C0")]
	private int NNEJCCHKNFL(int HCALFJOJKJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GNPACNBPGPM<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> IDDIEDEHIKK(TRequest HHNBCLDGHCL, CancellationToken LABHBAHABKB);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum EDDEDIBOCHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class OLONBLMGMED
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float GALLKFDHLKC = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan BBDBFCILHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int CJAPCNKNIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public EDDEDIBOCHA HICICBGJFFJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly OLONBLMGMED OCOPOGJODOC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float GJMFKNDAMKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x46F89D0", Offset = "0x46F79D0", VA = "0x1846F89D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LHFCMFOHPMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x46F8A40", Offset = "0x46F7A40", VA = "0x1846F8A40")]
		public OLONBLMGMED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct LAIMEOJHDHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest HHNBCLDGHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken LABHBAHABKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> BBGHNPFEHON;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x42D6100", Offset = "0x42D5100", VA = "0x1842D6100")]
		public LAIMEOJHDHD(TRequest HHNBCLDGHCL, TaskCompletionSource<TResult> BBGHNPFEHON, CancellationToken LABHBAHABKB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct NOPKMFPHAGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GNPACNBPGPM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4605C30", Offset = "0x4604C30", VA = "0x184605C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x46064F0", Offset = "0x46054F0", VA = "0x1846064F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct FPNBDGHJHBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GNPACNBPGPM<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private LAIMEOJHDHD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F0C0", Offset = "0x3C9E0C0", VA = "0x183C9F0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FCE0", Offset = "0x3C9ECE0", VA = "0x183C9FCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource ABOCJPLCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<LAIMEOJHDHD> JIGAPAGEMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly OLONBLMGMED NGEABGEKJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IDDIEDEHIKK KGJLDJLAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task HEGMJAEDJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int PCDAMELIJGO;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D96650", Offset = "0x3D95650", VA = "0x183D96650")]
	public GNPACNBPGPM(IDDIEDEHIKK KGJLDJLAJEP, [Optional] OLONBLMGMED NGEABGEKJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D95CA0", Offset = "0x3D94CA0", VA = "0x183D95CA0")]
	public Task<TResult> NKKJNEJKMHP(TRequest HHNBCLDGHCL, CancellationToken LABHBAHABKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D95360", Offset = "0x3D94360", VA = "0x183D95360")]
	private void GOPMIOCBNLF(LAIMEOJHDHD FOGECEMELFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D94CE0", Offset = "0x3D93CE0", VA = "0x183D94CE0")]
	[AsyncStateMachine(typeof(GNPACNBPGPM<, >.NOPKMFPHAGL))]
	private Task BJGALCNMDAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D95710", Offset = "0x3D94710", VA = "0x183D95710")]
	private LAIMEOJHDHD HKCNCNCLNIK()
	{
		return default(LAIMEOJHDHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D96560", Offset = "0x3D95560", VA = "0x183D96560")]
	[AsyncStateMachine(typeof(GNPACNBPGPM<, >.FPNBDGHJHBN))]
	private Task NODIAKAHKJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D950C0", Offset = "0x3D940C0", VA = "0x183D950C0")]
	private void GIPLJLNJNPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D94E80", Offset = "0x3D93E80", VA = "0x183D94E80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class GODNHFCNMMB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> IEKJOJONGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> AAKJNAIOJPG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x35E3D10", Offset = "0x35E2D10", VA = "0x1835E3D10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool KEMHBPIIPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x289ADC0", Offset = "0x2899DC0", VA = "0x18289ADC0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D97DB0", Offset = "0x3D96DB0", VA = "0x183D97DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1E70", Offset = "0x3CB0E70", VA = "0x183CB1E70", Slot = "11")]
	public void Add(T LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D972F0", Offset = "0x3D962F0", VA = "0x183D972F0")]
	public bool BAPAGMBLAJD(T LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D97BD0", Offset = "0x3D96BD0", VA = "0x183D97BD0", Slot = "15")]
	public bool Remove(T LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3D97520", Offset = "0x3D96520", VA = "0x183D97520", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3C01730", Offset = "0x3C00730", VA = "0x183C01730", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D973E0", Offset = "0x3D963E0", VA = "0x183D973E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3D97480", Offset = "0x3D96480", VA = "0x183D97480", Slot = "13")]
	public bool Contains(T LLGHCONMHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D974D0", Offset = "0x3D964D0", VA = "0x183D974D0", Slot = "14")]
	public void CopyTo(T[] IKONNGGNFPH, int MNPIBEICCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3D975B0", Offset = "0x3D965B0", VA = "0x183D975B0", Slot = "6")]
	public int IndexOf(T LLGHCONMHCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D97750", Offset = "0x3D96750", VA = "0x183D97750", Slot = "7")]
	public void Insert(int HCALFJOJKJO, T LLGHCONMHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D97890", Offset = "0x3D96890", VA = "0x183D97890", Slot = "8")]
	public void RemoveAt(int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3D97C90", Offset = "0x3D96C90", VA = "0x183D97C90")]
	public GODNHFCNMMB()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21F7C00", Offset = "0x21F6C00", VA = "0x1821F7C00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6950B10", Offset = "0x694FB10", VA = "0x186950B10")]
		public SerializedGuid([In] Guid CNIMPJMOLDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x69509E0", Offset = "0x694F9E0", VA = "0x1869509E0")]
		public static SerializedGuid NPCJJJFLHNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6950830", Offset = "0x694F830", VA = "0x186950830")]
		public static SerializedGuid ECGLICJBEAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6950980", Offset = "0x694F980", VA = "0x186950980")]
		public bool KFCLKKNDODJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6950AE0", Offset = "0x694FAE0", VA = "0x186950AE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6950A60", Offset = "0x694FA60", VA = "0x186950A60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x69508A0", Offset = "0x694F8A0", VA = "0x1869508A0", Slot = "7")]
		public bool Equals(SerializedGuid ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x69508E0", Offset = "0x694F8E0", VA = "0x1869508E0", Slot = "0")]
		public override bool Equals(object NOPFNIKINJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6950970", Offset = "0x694F970", VA = "0x186950970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6950800", Offset = "0x694F800", VA = "0x186950800", Slot = "6")]
		public int CompareTo(SerializedGuid ACBLPNJDJBF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PMGABLEBHHL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type AKFFLPDCMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string ANKIKBOLEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EGMDMDBIBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool NNIOKLGHPCD;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x694EE30", Offset = "0x694DE30", VA = "0x18694EE30")]
	public PMGABLEBHHL(Type OKKEMIMEAFA, string BIMBEDAJPNJ, bool DCIKKNFAPFH = false, bool CJABCGLCDJN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KLCBNGOGDPF<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct KPKFJKDEHBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long IJCEAIKNCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long CPABDKAKIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int CJADJGKDKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int JLIOKHOJNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool MIECOLHHKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string KOINMLBGFON;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x425D590", Offset = "0x425C590", VA = "0x18425D590")]
		public KPKFJKDEHBA(long IJCEAIKNCHO, int CJADJGKDKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x425D600", Offset = "0x425C600", VA = "0x18425D600")]
		public KPKFJKDEHBA(long IJCEAIKNCHO, long CPABDKAKIBJ, int CJADJGKDKFJ, int JLIOKHOJNKI, bool MIECOLHHKIM, string KOINMLBGFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x425D520", Offset = "0x425C520", VA = "0x18425D520")]
		public int JMBBKNJHEOA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x425D570", Offset = "0x425C570", VA = "0x18425D570")]
		public int LHPKIGNKFGL(int DNBKEDCPGMN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x425D420", Offset = "0x425C420", VA = "0x18425D420")]
		public double CJCJEJGOHIC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x425D480", Offset = "0x425C480", VA = "0x18425D480")]
		public KPKFJKDEHBA JHDAAGCAKLK(long CPABDKAKIBJ, int JLIOKHOJNKI)
		{
			return default(KPKFJKDEHBA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class BPJNBAPCFPO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct PMGEKPLEDPH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public BPJNBAPCFPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<BPJNBAPCFPO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private BPJNBAPCFPO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x47ADAD0", Offset = "0x47ACAD0", VA = "0x1847ADAD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3898510", Offset = "0x3897510", VA = "0x183898510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey NAKCNJCFEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly KLCBNGOGDPF<TKey> COCKABGNCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly PHLKHBEJKKB IGEICKLFDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<BPJNBAPCFPO> BIAOOFIFPDI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string KCKAOKHOGLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3DC5C80", Offset = "0x3DC4C80", VA = "0x183DC5C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<BPJNBAPCFPO> NMONFNJHMBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x4EB4570", Offset = "0x4EB3570", VA = "0x184EB4570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KPKFJKDEHBA PNGFCBIOIAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x4EB45E0", Offset = "0x4EB35E0", VA = "0x184EB45E0")]
			[CompilerGenerated]
			get
			{
				return default(KPKFJKDEHBA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4EB45B0", Offset = "0x4EB35B0", VA = "0x184EB45B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4600", Offset = "0x4EB3600", VA = "0x184EB4600")]
		internal BPJNBAPCFPO(KLCBNGOGDPF<TKey> COCKABGNCJJ, TKey GMFCIHEFPPO, PHLKHBEJKKB IGEICKLFDBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4EB43C0", Offset = "0x4EB33C0", VA = "0x184EB43C0")]
		public BPJNBAPCFPO GNGICDLMAFD(TKey GMFCIHEFPPO, [Optional] PHLKHBEJKKB? MCMDDFEOFFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2894A90", Offset = "0x2893A90", VA = "0x182894A90")]
		[AsyncStateMachine(typeof(PMGEKPLEDPH<>))]
		public Task<T> LOHELFPJFKG<T>(TKey GMFCIHEFPPO, Func<BPJNBAPCFPO, Task<T>> BOJOFOCMOIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4180", Offset = "0x4EB3180", VA = "0x184EB4180", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PEHLEHMLLGI : IEnumerable<(TKey, List<TKey>, KPKFJKDEHBA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KPKFJKDEHBA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, KPKFJKDEHBA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KLCBNGOGDPF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, KPKFJKDEHBA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, KPKFJKDEHBA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x21FD650", Offset = "0x21FC650", VA = "0x1821FD650", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KPKFJKDEHBA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x47A2D90", Offset = "0x47A1D90", VA = "0x1847A2D90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21FD740", Offset = "0x21FC740", VA = "0x1821FD740")]
		[DebuggerHidden]
		public PEHLEHMLLGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3AA34E0", Offset = "0x3AA24E0", VA = "0x183AA34E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x47A28D0", Offset = "0x47A18D0", VA = "0x1847A28D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x47A2880", Offset = "0x47A1880", VA = "0x1847A2880")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x47A2D40", Offset = "0x47A1D40", VA = "0x1847A2D40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x47A2C70", Offset = "0x47A1C70", VA = "0x1847A2C70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KPKFJKDEHBA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB5D0", Offset = "0x3AAA5D0", VA = "0x183AAB5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class KKKEODJHCCL : IEnumerable<(TKey, List<TKey>, KPKFJKDEHBA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KPKFJKDEHBA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, KPKFJKDEHBA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private BPJNBAPCFPO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public BPJNBAPCFPO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KLCBNGOGDPF<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<BPJNBAPCFPO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, KPKFJKDEHBA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, KPKFJKDEHBA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x21FD650", Offset = "0x21FC650", VA = "0x1821FD650", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KPKFJKDEHBA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4248710", Offset = "0x4247710", VA = "0x184248710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x21FD740", Offset = "0x21FC740", VA = "0x1821FD740")]
		[DebuggerHidden]
		public KKKEODJHCCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4248770", Offset = "0x4247770", VA = "0x184248770", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4247D50", Offset = "0x4246D50", VA = "0x184247D50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4247CF0", Offset = "0x4246CF0", VA = "0x184247CF0")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4248520", Offset = "0x4247520", VA = "0x184248520")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x42486C0", Offset = "0x42476C0", VA = "0x1842486C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4248580", Offset = "0x4247580", VA = "0x184248580", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KPKFJKDEHBA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4248680", Offset = "0x4247680", VA = "0x184248680", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, KPKFJKDEHBA, PHLKHBEJKKB> AIEBPLHEJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, KPKFJKDEHBA, PHLKHBEJKKB> OFIAOELGDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<KLCBNGOGDPF<TKey>, PHLKHBEJKKB> DFAAPDFKFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly BPJNBAPCFPO OPAEAKAHDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool IHDIIKNEDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int EOKHENJCHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch HPLGJKMDCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int EMDMENBGJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string LAKMBHIOCMJ;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public BPJNBAPCFPO JOEMLNHBGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string KCKAOKHOGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x424B4D0", Offset = "0x424A4D0", VA = "0x18424B4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x424B6B0", Offset = "0x424A6B0", VA = "0x18424B6B0")]
	public KLCBNGOGDPF(TKey MPCHNIDNMNP, PHLKHBEJKKB IGEICKLFDBC, [Optional] int? CJADJGKDKFJ, [Optional][CanBeNull] Stopwatch HPLGJKMDCMA, [Optional] Action<TKey, KPKFJKDEHBA, PHLKHBEJKKB> AIEBPLHEJLK, [Optional] Action<TKey, KPKFJKDEHBA, PHLKHBEJKKB> OFIAOELGDBC, [Optional] Action<KLCBNGOGDPF<TKey>, PHLKHBEJKKB> DFAAPDFKFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x424B400", Offset = "0x424A400", VA = "0x18424B400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x424B530", Offset = "0x424A530", VA = "0x18424B530")]
	[IteratorStateMachine(typeof(KLCBNGOGDPF<>.PEHLEHMLLGI))]
	public IEnumerable<(TKey, List<TKey>, KPKFJKDEHBA)> NNFNCBDMBKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x424B5D0", Offset = "0x424A5D0", VA = "0x18424B5D0")]
	[IteratorStateMachine(typeof(KLCBNGOGDPF<>.KKKEODJHCCL))]
	private IEnumerable<(TKey, List<TKey>, KPKFJKDEHBA)> NNFNCBDMBKL(List<TKey> PLCNFEGEAJG, BPJNBAPCFPO DOLKNGHMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x424B380", Offset = "0x424A380", VA = "0x18424B380")]
	private (long, int) DHKGEDIFAGH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class LCHJAKODFNJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut MGDPLCPLGAI(KLCBNGOGDPF<TKey> COCKABGNCJJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected LCHJAKODFNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class MOBIEHJFLEG<TKey> : LCHJAKODFNJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string EKBMDDELGPD(TKey GMFCIHEFPPO);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x450AF70", Offset = "0x4509F70", VA = "0x18450AF70")]
	private static string PAKNIKBOMAH(TKey GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x450AE90", Offset = "0x4509E90", VA = "0x18450AE90", Slot = "4")]
	public override string MGDPLCPLGAI(KLCBNGOGDPF<TKey> COCKABGNCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x450AD40", Offset = "0x4509D40", VA = "0x18450AD40")]
	public string MGDPLCPLGAI(KLCBNGOGDPF<TKey> COCKABGNCJJ, [NotNull] EKBMDDELGPD AIGIEHAPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GDPHENBOLKF(KLCBNGOGDPF<TKey> COCKABGNCJJ, [NotNull] EKBMDDELGPD AIGIEHAPODG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FD80", Offset = "0x3F4ED80", VA = "0x183F4FD80")]
	protected MOBIEHJFLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class PPHGFGICGOP<TKey> : LCHJAKODFNJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string IPFAKCAKKNP(TKey GMFCIHEFPPO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string KNLIOJIIKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double GGOKOMBALKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool OOIBDBFIFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int JOPCOFBDGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> IMPNLCDKAFN;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x47CDD80", Offset = "0x47CCD80", VA = "0x1847CDD80")]
	private static string PAKNIKBOMAH(TKey GMFCIHEFPPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x47CDDC0", Offset = "0x47CCDC0", VA = "0x1847CDDC0")]
	public PPHGFGICGOP(string KNLIOJIIKEK = "F2", double GGOKOMBALKB = double.MaxValue, bool OOIBDBFIFBH = false, int JOPCOFBDGJK = int.MaxValue, [Optional] ISet<string> IMPNLCDKAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x47CDBC0", Offset = "0x47CCBC0", VA = "0x1847CDBC0", Slot = "4")]
	public override Dictionary<string, string> MGDPLCPLGAI(KLCBNGOGDPF<TKey> COCKABGNCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x47CDCA0", Offset = "0x47CCCA0", VA = "0x1847CDCA0")]
	private bool MHEIGFPJLPM(string DAGLPGFHNJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x47CD590", Offset = "0x47CC590", VA = "0x1847CD590")]
	public Dictionary<string, string> MGDPLCPLGAI(KLCBNGOGDPF<TKey> COCKABGNCJJ, IPFAKCAKKNP AIGIEHAPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x47CD320", Offset = "0x47CC320", VA = "0x1847CD320")]
	private string FMHFKMODBBK(StringBuilder CJEFGKNGFNC, List<TKey> KLBDNEBDBCK, IPFAKCAKKNP AIGIEHAPODG, bool EJKHNDGLMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x47CD1C0", Offset = "0x47CC1C0", VA = "0x1847CD1C0")]
	private static void DBHOKHLCOPO(StringBuilder LGPKJAAPGFJ, string CGBJKBNFKJL, bool OAAKKJMILGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NPKHAODEAJC<TKey> : MOBIEHJFLEG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IEPPICJDHFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public EKBMDDELGPD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static NPKHAODEAJC<TKey> PNNELGGLBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] PBDJMEMHCHH;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x460AD80", Offset = "0x4609D80", VA = "0x18460AD80")]
	private NPKHAODEAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4609CF0", Offset = "0x4608CF0", VA = "0x184609CF0", Slot = "5")]
	protected override string GDPHENBOLKF(KLCBNGOGDPF<TKey> COCKABGNCJJ, EKBMDDELGPD AIGIEHAPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x460AB40", Offset = "0x4609B40", VA = "0x18460AB40")]
	[CompilerGenerated]
	internal static string NCBEODAMNIK(string OFJLFKILPPJ, TKey GMFCIHEFPPO, IEPPICJDHFP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JPPNOPBCNJD : KLCBNGOGDPF<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class KBBLNFPIAHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<JPPNOPBCNJD, PHLKHBEJKKB> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public KBBLNFPIAHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x694E250", Offset = "0x694D250", VA = "0x18694E250")]
		internal void BDEECAHPFOA(KLCBNGOGDPF<string> timer, PHLKHBEJKKB log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x694E100", Offset = "0x694D100", VA = "0x18694E100")]
	public JPPNOPBCNJD(PHLKHBEJKKB IGEICKLFDBC, [Optional] string OELLILECDPC, [Optional] int? CJADJGKDKFJ, [Optional] Stopwatch HPLGJKMDCMA, [Optional] Action<string, KPKFJKDEHBA, PHLKHBEJKKB> AIEBPLHEJLK, [Optional] Action<string, KPKFJKDEHBA, PHLKHBEJKKB> OFIAOELGDBC, [Optional] Action<JPPNOPBCNJD, PHLKHBEJKKB> DFAAPDFKFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x694E040", Offset = "0x694D040", VA = "0x18694E040")]
	private static Action<KLCBNGOGDPF<string>, PHLKHBEJKKB> HBHGKNHKKNJ(Action<JPPNOPBCNJD, PHLKHBEJKKB> IPCEAEAAIHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class DBKDKCMLOON
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class CINJMAGFAKD : DBKDKCMLOON
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static DBKDKCMLOON PNNELGGLBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x694DB40", Offset = "0x694CB40", VA = "0x18694DB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float BDLGGIIAFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xA91AF0", Offset = "0xA90AF0", VA = "0x180A91AF0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x694DC40", Offset = "0x694CC40", VA = "0x18694DC40")]
		public CINJMAGFAKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static DBKDKCMLOON PCCDDMLDOHD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static DBKDKCMLOON OCOPOGJODOC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x694DE50", Offset = "0x694CE50", VA = "0x18694DE50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float BDLGGIIAFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected DBKDKCMLOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KEHNINOIGAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GJJBOODDAKM<T> : KEHNINOIGAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> CJODOOHPEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	EPEDBCONEGO<T> HNNLPEEDKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OKBGBIOLKAL
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2D58250", Offset = "0x2D57250", VA = "0x182D58250")]
	public static GJJBOODDAKM<TResource> BMFAOAHNLMC<TResource, TId>(this ANCOHNGNEPM<TId, TResource> JLBEALEHLIN, TId KHLDDJPHOBA, [Optional] Func<TId, CancellationToken, Task<TResource>>? AJDAJFEOMGJ) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LFEHJHHLCJG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class LGGPPKFIKDD<T> : MCPINNNNCGK<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override EPEDBCONEGO<T?> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x42E8720", Offset = "0x42E7720", VA = "0x1842E8720")]
		public LGGPPKFIKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class OJIFAKKNFOD<T> : MCPINNNNCGK<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T AIGPAGLDIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? HKFKJFMKPBL;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override EPEDBCONEGO<T> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x46F3BE0", Offset = "0x46F2BE0", VA = "0x1846F3BE0")]
		public OJIFAKKNFOD(T APCOPGLENMB, Action<T>? AELCBPEPGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x46F39B0", Offset = "0x46F29B0", VA = "0x1846F39B0", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class MIJMHNENBLB<T> : MCPINNNNCGK<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override EPEDBCONEGO<T> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x44E9FC0", Offset = "0x44E8FC0", VA = "0x1844E9FC0")]
		public MIJMHNENBLB(Exception KCICFLBDCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class HAEDBEJEEMC<T> : MCPINNNNCGK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct APGFJAHNKON : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<GJJBOODDAKM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<GJJBOODDAKM<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3F5C620", Offset = "0x3F5B620", VA = "0x183F5C620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3F5D000", Offset = "0x3F5C000", VA = "0x183F5D000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct MDMHOFBMIOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<GJJBOODDAKM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<GJJBOODDAKM<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x44D4FF0", Offset = "0x44D3FF0", VA = "0x1844D4FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x44D5280", Offset = "0x44D4280", VA = "0x1844D5280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<GJJBOODDAKM<T>> JLNINFKCDHH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override EPEDBCONEGO<T> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0130", Offset = "0x3DBF130", VA = "0x183DC0130")]
		public HAEDBEJEEMC(Task<GJJBOODDAKM<T>> FGPHJGHMKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFEE0", Offset = "0x3DBEEE0", VA = "0x183DBFEE0", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFCF0", Offset = "0x3DBECF0", VA = "0x183DBFCF0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HAEDBEJEEMC<>.APGFJAHNKON))]
		internal static Task<T> LOMEPPCGFPH(Task<GJJBOODDAKM<T>> FGPHJGHMKNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0050", Offset = "0x3DBF050", VA = "0x183DC0050")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HAEDBEJEEMC<>.MDMHOFBMIOP))]
		internal static Task OKLPGFFEDGG(Task<GJJBOODDAKM<T>> FGPHJGHMKNM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MBJFPPOFCII<TIn, TOut> : MCPINNNNCGK<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct MEJLIBFEKMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x44DF360", Offset = "0x44DE360", VA = "0x1844DF360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x42D6B80", Offset = "0x42D5B80", VA = "0x1842D6B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly GJJBOODDAKM<TIn> ANOBCAPNCFB;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> CJODOOHPEDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override EPEDBCONEGO<TOut> HNNLPEEDKOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x44CE0A0", Offset = "0x44CD0A0", VA = "0x1844CE0A0")]
		public MBJFPPOFCII(GJJBOODDAKM<TIn> FACCLGPBPPF, Func<TIn, TOut> AKMNPADPNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x44CE000", Offset = "0x44CD000", VA = "0x1844CE000", Slot = "10")]
		protected override void OKDOICBOLIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x44CDE80", Offset = "0x44CCE80", VA = "0x1844CDE80")]
		[AsyncStateMachine(typeof(MBJFPPOFCII<, >.MEJLIBFEKMK))]
		[CompilerGenerated]
		internal static Task<TOut> EMFNBLFEKGK(Task<TIn> GGMBCHLBGNH, Func<TIn, TOut> AKMNPADPNDI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C550", Offset = "0x2C7B550", VA = "0x182C7C550")]
	public static GJJBOODDAKM<T> MEMMBNOMLFC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C4A0", Offset = "0x2C7B4A0", VA = "0x182C7C4A0")]
	public static GJJBOODDAKM<T> FFLBLMODBPC<T>(T KNFGDDANCCK, [Optional] Action<T>? AELCBPEPGGI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static GJJBOODDAKM<T> OJNJHOBHHJH<T>(Exception KCICFLBDCAB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB96B0", Offset = "0x2BB86B0", VA = "0x182BB96B0")]
	public static GJJBOODDAKM<T> NKAEMMAEDMF<T>(Task<GJJBOODDAKM<T>> FGPHJGHMKNM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2995270", Offset = "0x2994270", VA = "0x182995270")]
	public static GJJBOODDAKM<TOut> EALAKNFEFIK<TOut, TIn>(GJJBOODDAKM<TIn> EFPCBKOLOGB, Func<TIn, TOut> AKMNPADPNDI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class MCPINNNNCGK<T> : GJJBOODDAKM<T>, KEHNINOIGAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string HDLODOHDLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DIIOFOPNEPI LPKIKJCFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool IHDIIKNEDCC;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool HALEFOFGOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC5CD80", Offset = "0xC5BD80", VA = "0x180C5CD80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> CJODOOHPEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract EPEDBCONEGO<T> HNNLPEEDKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x44D3EC0", Offset = "0x44D2EC0", VA = "0x1844D3EC0")]
	public MCPINNNNCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x44D3B40", Offset = "0x44D2B40", VA = "0x1844D3B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OKDOICBOLIK();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class MGBFCHOBOBP<TTask, T> : MCPINNNNCGK<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class LMBDIODMACO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public LMBDIODMACO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x35D1930", Offset = "0x35D0930", VA = "0x1835D1930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x35D1E80", Offset = "0x35D0E80", VA = "0x1835D1E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public MGBFCHOBOBP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LMBDIODMACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x43066E0", Offset = "0x43056E0", VA = "0x1843066E0")]
		[AsyncStateMachine(typeof(MGBFCHOBOBP<, >.LMBDIODMACO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OPKADLPOEOL(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> FGPHJGHMKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource DJMJNBDHLHM;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> CJODOOHPEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override EPEDBCONEGO<T> HNNLPEEDKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x44E6CB0", Offset = "0x44E5CB0", VA = "0x1844E6CB0")]
	protected MGBFCHOBOBP(TTask FGPHJGHMKNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x44E6C60", Offset = "0x44E5C60", VA = "0x1844E6C60", Slot = "10")]
	protected override void OKDOICBOLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CAIGDFEDKCP(TTask HMLOALPMAAP);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void HKMPBCKENOH();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EGNEBHFJEFH<T> : MCPINNNNCGK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly OKJGCOPDBJF<Task<T>> FBDBKAICNHE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> CJODOOHPEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3899B20", Offset = "0x3898B20", VA = "0x183899B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override EPEDBCONEGO<T> HNNLPEEDKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3899B90", Offset = "0x3898B90", VA = "0x183899B90")]
	public EGNEBHFJEFH(OKJGCOPDBJF<Task<T>> IIIELFJGACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3899B70", Offset = "0x3898B70", VA = "0x183899B70", Slot = "10")]
	protected override void OKDOICBOLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class OGFONCGFNMH
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName DBBCJDIGLBD;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> FOLGACNKBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x694E530", Offset = "0x694D530", VA = "0x18694E530")]
	public static int JHJPGCGPLNG(this JODLHPFGCKF COGACGBBLCJ, IncrementalHash NPOAPJJLLAJ, byte[] IPPKEMENLPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x694E8E0", Offset = "0x694D8E0", VA = "0x18694E8E0")]
	public static bool LPMOJFELBFK([CanBeNull] this JODLHPFGCKF COGACGBBLCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x694E940", Offset = "0x694D940", VA = "0x18694E940")]
	public static bool LPMOJFELBFK([CanBeNull] this JODLHPFGCKF COGACGBBLCJ, [Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x694E5B0", Offset = "0x694D5B0", VA = "0x18694E5B0")]
	public static bool LPMOJFELBFK([CanBeNull] this JODLHPFGCKF COGACGBBLCJ, IncrementalHash NPOAPJJLLAJ, byte[] IPPKEMENLPP, [Out] string EHELKEOJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x694EC50", Offset = "0x694DC50", VA = "0x18694EC50")]
	private static bool MONCLGMPBBI(byte[] PJGAHPJOPEC, Span<byte> DHODAMLALBJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class AODEBLAAGOA
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x694B6C0", Offset = "0x694A6C0", VA = "0x18694B6C0")]
	public static int PNPIPJCGBEL(HashAlgorithmName KKMMMFENJKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x694B460", Offset = "0x694A460", VA = "0x18694B460")]
	public static int JHJPGCGPLNG(this INAIILMGFEG DNLJNHEGAJC, byte[] OOACOGJIJMI, IncrementalHash NPOAPJJLLAJ, byte[] LONMHNKBNKK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface INAIILMGFEG
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NPOAPJJLLAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface JODLHPFGCKF : INAIILMGFEG
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] KOHGCCNOJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] PNFPJMDNDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BMPIJDACPMK
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool FJPKAMDDMDN;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> BGOHGLEGEDA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> CKAEJOKHOAC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding GFJLFFHOFAD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> AHJJBKJODEJ;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x292E030", Offset = "0x292D030", VA = "0x18292E030")]
	public static void HPJLOIDFKDO<T>(this IncrementalHash BJPFCJLEEAK, [CanBeNull] T EMPBMFAFICE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x292DFA0", Offset = "0x292CFA0", VA = "0x18292DFA0")]
	public static void FMCOFOMGDCH<T>(this IncrementalHash BJPFCJLEEAK, [CanBeNull] T DNLJNHEGAJC) where T : INAIILMGFEG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x292E720", Offset = "0x292D720", VA = "0x18292E720")]
	public static void OOHGBMMHANK<T>(this IncrementalHash BJPFCJLEEAK, [CanBeNull] IList<T> IFOCNACJICA) where T : INAIILMGFEG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x694B8E0", Offset = "0x694A8E0", VA = "0x18694B8E0")]
	private static bool AMNFLMPKNOO([CanBeNull] INAIILMGFEG DNLJNHEGAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x694B970", Offset = "0x694A970", VA = "0x18694B970")]
	public static void CFHGFHJNPJD(this IncrementalHash NPOAPJJLLAJ, string? CJEFOBHKGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x694C480", Offset = "0x694B480", VA = "0x18694C480")]
	public static void HGHCEFABMGH(this IncrementalHash NPOAPJJLLAJ, long PBCINNKADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x694BD80", Offset = "0x694AD80", VA = "0x18694BD80")]
	public static void DKHKLHOANKD(this IncrementalHash NPOAPJJLLAJ, int BHELPMDNDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x694C650", Offset = "0x694B650", VA = "0x18694C650")]
	public static void PNGEDAEFKEA(this IncrementalHash NPOAPJJLLAJ, short DLBPNAAPLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x694C370", Offset = "0x694B370", VA = "0x18694C370")]
	public static void HACCACCJNOE(this IncrementalHash NPOAPJJLLAJ, byte NPKBGLBKJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x694BF50", Offset = "0x694AF50", VA = "0x18694BF50")]
	public static void DLIIDOFHLNO(this IncrementalHash NPOAPJJLLAJ, bool FAMAKIDKNPK, bool BNCBPENOFLJ = false, bool BFAMBAKPDEB = false, bool LFDAJCHKCOG = false, bool CEEGBNNFIJD = false, bool GDOOCLDAAOB = false, bool CGIHACLIJEG = false, bool FOLBKMFDKAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x292E0F0", Offset = "0x292D0F0", VA = "0x18292E0F0")]
	public static void IKLPJGOPCFP<T>(this IncrementalHash NPOAPJJLLAJ, T EIIABACMOFJ) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x694C1F0", Offset = "0x694B1F0", VA = "0x18694C1F0")]
	public static void EOOBFCIMPNP(this IncrementalHash NPOAPJJLLAJ, float FFGAAEGHMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x694C2B0", Offset = "0x694B2B0", VA = "0x18694C2B0")]
	public static void GCCEBBEMGLN(this IncrementalHash NPOAPJJLLAJ, ulong MDLFOCEBBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x694C250", Offset = "0x694B250", VA = "0x18694C250")]
	public static void FGAKKLKCJHG(this IncrementalHash NPOAPJJLLAJ, uint HHGEMGFFJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x694C310", Offset = "0x694B310", VA = "0x18694C310")]
	public static void GMDONOGHDNI(this IncrementalHash NPOAPJJLLAJ, ushort FBAFLHCCFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x694C0C0", Offset = "0x694B0C0", VA = "0x18694C0C0")]
	public static void ECDCJEHKLAN(this IncrementalHash NPOAPJJLLAJ, Vector3 IIAMGJENDJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NEGOJHEOMFD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x694E2E0", Offset = "0x694D2E0", VA = "0x18694E2E0")]
	public NEGOJHEOMFD(string KKHEHGHPOAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class LBOADEHOIJB<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class LIGKOJJNHIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode KALCJEIICGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode EMOKCJBMKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JOCGKFCDBPI HMLGIEBFMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<JOCGKFCDBPI> ANINBHJBNAP;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public LIGKOJJNHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct JOCGKFCDBPI : IComparable<JOCGKFCDBPI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int NGLFEFNBMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant AFMOLAJIOFN;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
		public JOCGKFCDBPI(int NGLFEFNBMMA, TClaimant AFMOLAJIOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x411B960", Offset = "0x411A960", VA = "0x18411B960")]
		public bool NEJPBNDDNDD([In] JOCGKFCDBPI ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x411B950", Offset = "0x411A950", VA = "0x18411B950")]
		public bool JFBCNMNKEIP([In] JOCGKFCDBPI ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x411B940", Offset = "0x411A940", VA = "0x18411B940", Slot = "4")]
		public int CompareTo(JOCGKFCDBPI ACBLPNJDJBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x411B9C0", Offset = "0x411A9C0", VA = "0x18411B9C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum ELOPAAGPLHN
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JLLGIHEGCAG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public LBOADEHOIJB<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4A30", Offset = "0x8A3A30", VA = "0x1808A4A30")]
		[DebuggerHidden]
		public JLLGIHEGCAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x41184A0", Offset = "0x41174A0", VA = "0x1841184A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4118670", Offset = "0x4117670", VA = "0x184118670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4118580", Offset = "0x4117580", VA = "0x184118580", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4AB0", Offset = "0x3AA3AB0", VA = "0x183AA4AB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly IDPKEELFKKI<LIGKOJJNHIF> IAKCEIGILMG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IDPKEELFKKI<List<JOCGKFCDBPI>> OFMAHMIBHMP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int OLGLGOMOALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> NLNFIDHIJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, LIGKOJJNHIF> NHPNCOGDPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private ELOPAAGPLHN HIJBNPKNLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool OJOGLGJEHMD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PIEECFGNFDJ(TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void FPEOHMHJHHH(TNode OHDOOCGHDGN, TClaimant KCGIOIHPLIK, TClaimant BOPGAAFLHIM);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x42D9570", Offset = "0x42D8570", VA = "0x1842D9570")]
	public LBOADEHOIJB(ELOPAAGPLHN HIJBNPKNLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x42D92E0", Offset = "0x42D82E0", VA = "0x1842D92E0")]
	public void OLGCEFHDKFL(TNode OHDOOCGHDGN, TNode MECDJMBEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x42D8510", Offset = "0x42D7510", VA = "0x1842D8510")]
	public void GBLAPNMEKNK(TClaimant AFMOLAJIOFN, TNode FFHAFJDMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x42D8310", Offset = "0x42D7310", VA = "0x1842D8310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x42D9210", Offset = "0x42D8210", VA = "0x1842D9210")]
	private void OFNCAHIAOAL(TClaimant AFMOLAJIOFN, TNode FNIDCMMELOC, TNode FFHAFJDMHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x42D8680", Offset = "0x42D7680", VA = "0x1842D8680")]
	private int GLJDLJICKOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x42D8D10", Offset = "0x42D7D10", VA = "0x1842D8D10")]
	private void LPHHCFOGMMI(TClaimant AFMOLAJIOFN, TNode HAIPBMOLIFK, TNode EKGLHBPPKHM, int HMMBPNHLGKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x42D8AE0", Offset = "0x42D7AE0", VA = "0x1842D8AE0")]
	private void LMBCPAENDCF(JOCGKFCDBPI CAPDCDKMBMA, LIGKOJJNHIF CBKMIAOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x42D7CD0", Offset = "0x42D6CD0", VA = "0x1842D7CD0")]
	private void BOOEPKNEAPC(TClaimant AFMOLAJIOFN, TNode HAIPBMOLIFK, TNode EKGLHBPPKHM, int HMMBPNHLGKL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x42D7BA0", Offset = "0x42D6BA0", VA = "0x1842D7BA0")]
	private void ALJDBGIGJPB(JOCGKFCDBPI CAPDCDKMBMA, TNode OHDOOCGHDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x42D8BB0", Offset = "0x42D7BB0", VA = "0x1842D8BB0")]
	private void LOJKOGDNNMD(JOCGKFCDBPI CAPDCDKMBMA, LIGKOJJNHIF CBKMIAOMAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x42D8880", Offset = "0x42D7880", VA = "0x1842D8880")]
	private void KJKHGFPEJDK(LIGKOJJNHIF CBKMIAOMAIC, bool HHLPMAPHJLN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x42D7FC0", Offset = "0x42D6FC0", VA = "0x1842D7FC0")]
	private void CIDHHGLPHIK(LIGKOJJNHIF CBKMIAOMAIC, TNode MECDJMBEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x42D7AB0", Offset = "0x42D6AB0", VA = "0x1842D7AB0")]
	[IteratorStateMachine(typeof(LBOADEHOIJB<, >.JLLGIHEGCAG))]
	private IEnumerable<TNode> AAGBEBGDDAK(TNode HAIPBMOLIFK, TNode EKGLHBPPKHM, bool LEGHMNNHLEC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x42D89D0", Offset = "0x42D79D0", VA = "0x1842D89D0")]
	private LIGKOJJNHIF LJANDNEODLG(TNode OHDOOCGHDGN, TNode EMOKCJBMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x42D86F0", Offset = "0x42D76F0", VA = "0x1842D86F0")]
	private LIGKOJJNHIF JLPOAGNMNOB(TNode OHDOOCGHDGN, TNode EMOKCJBMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x42D9050", Offset = "0x42D8050", VA = "0x1842D9050")]
	private void NNMCGFBPNPA(LIGKOJJNHIF CBKMIAOMAIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GHNLIJONBBO<T> : IEnumerable<GHNLIJONBBO<T>.NGAOHLKPJEC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct NGAOHLKPJEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T JJCEIJMGOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int HCALFJOJKJO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class CLJOAOGFIMG : IEnumerator<NGAOHLKPJEC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private GHNLIJONBBO<T> DPGGOEHOLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int HCALFJOJKJO;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x38BCDF0", Offset = "0x38BBDF0", VA = "0x1838BCDF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NGAOHLKPJEC NIGOAHBKKGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x545E450", Offset = "0x545D450", VA = "0x18545E450", Slot = "4")]
			get
			{
				return default(NGAOHLKPJEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x545E410", Offset = "0x545D410", VA = "0x18545E410")]
		public CLJOAOGFIMG(GHNLIJONBBO<T> DPGGOEHOLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x545E390", Offset = "0x545D390", VA = "0x18545E390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3912650", Offset = "0x3911650", VA = "0x183912650", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0AF80", Offset = "0xA09F80", VA = "0x180A0AF80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct KDHBAGFEAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool IAIOFOJNHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T JJCEIJMGOAB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int CCAFHADDCKL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> GGPIPGLGCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KDHBAGFEAJA[] FFAMKBLEEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int ELPCLMAEPKE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int APHKPFHFKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x891670", Offset = "0x890670", VA = "0x180891670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x890C60", Offset = "0x88FC60", VA = "0x180890C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x35E3D10", Offset = "0x35E2D10", VA = "0x1835E3D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F0D0", Offset = "0x3D6E0D0", VA = "0x183D6F0D0")]
	public GHNLIJONBBO(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F5E0", Offset = "0x3D6E5E0", VA = "0x183D6F5E0")]
	public GHNLIJONBBO(NGAOHLKPJEC[] KAONHBEAEJH, bool DEFBMMKAMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EF80", Offset = "0x3D6DF80", VA = "0x183D6EF80")]
	public int PHGIAEEEGCP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EB00", Offset = "0x3D6DB00", VA = "0x183D6EB00")]
	private int DFNKLMKCDOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EF30", Offset = "0x3D6DF30", VA = "0x183D6EF30", Slot = "6")]
	protected virtual uint MNBAIKEMHAI(uint NPOAPJJLLAJ, T JJCEIJMGOAB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3D6ED00", Offset = "0x3D6DD00", VA = "0x183D6ED00")]
	public bool FKCOFDIIDDJ(T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E2E0", Offset = "0x3D6D2E0", VA = "0x183D6E2E0")]
	public int AIMBABCDMJH(T JJCEIJMGOAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EE70", Offset = "0x3D6DE70", VA = "0x183D6EE70")]
	public T JFBGKIODNAI(int HCALFJOJKJO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E360", Offset = "0x3D6D360", VA = "0x183D6E360")]
	public bool BAPAGMBLAJD(T JJCEIJMGOAB, bool PKIIJNMKGAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E650", Offset = "0x3D6D650", VA = "0x183D6E650")]
	public bool BAPAGMBLAJD(T JJCEIJMGOAB, int HCALFJOJKJO, bool PKIIJNMKGAM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EE20", Offset = "0x3D6DE20", VA = "0x183D6EE20")]
	private int FLGHKMCALAO(int EFHNBALPFBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F030", Offset = "0x3D6E030", VA = "0x183D6F030", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F030", Offset = "0x3D6E030", VA = "0x183D6F030", Slot = "4")]
	private IEnumerator<NGAOHLKPJEC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class IDPKEELFKKI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> ELCGDHICFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> GEOGHICDKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int EHDLDAACBDL;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3EBAEA0", Offset = "0x3EB9EA0", VA = "0x183EBAEA0")]
	public static IDPKEELFKKI<T> BBFMBDLLONF(int BPIECAEAGAJ = 0, int EHDLDAACBDL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB150", Offset = "0x3EBA150", VA = "0x183EBB150")]
	public static IDPKEELFKKI<T> MAMPNFKFBFH(int BPIECAEAGAJ = 0, int EHDLDAACBDL = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB600", Offset = "0x3EBA600", VA = "0x183EBB600")]
	public IDPKEELFKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB650", Offset = "0x3EBA650", VA = "0x183EBB650")]
	public IDPKEELFKKI(int BPIECAEAGAJ, int EHDLDAACBDL = int.MaxValue, bool LKHBHPKGEIO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3EBAD00", Offset = "0x3EB9D00", VA = "0x183EBAD00")]
	public T AAMNLOAKCMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB340", Offset = "0x3EBA340", VA = "0x183EBB340")]
	public void ONMBONLCIME(T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB240", Offset = "0x3EBA240", VA = "0x183EBB240")]
	private void NIKMFNOIKMO(T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB110", Offset = "0x3EBA110", VA = "0x183EBB110")]
	private void EHIMFFNGDFO(T JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3EBAF90", Offset = "0x3EB9F90", VA = "0x183EBAF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3EBB410", Offset = "0x3EBA410", VA = "0x183EBB410")]
	private void PFGMNBMPHBK(IEnumerable<T> ADLAOOMHAPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MJLBDDEDJIL<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> PDKIFAKOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T OOLGFGOJGMB;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T NFNPMELFGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x44ECC70", Offset = "0x44EBC70", VA = "0x1844ECC70")]
	public bool CPIPAMHCHDK(T JJCEIJMGOAB, int NGLFEFNBMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x430A7F0", Offset = "0x43097F0", VA = "0x18430A7F0")]
	public bool FDNJFPDHLCC(int NGLFEFNBMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x44EC9D0", Offset = "0x44EB9D0", VA = "0x1844EC9D0")]
	public T BBNBKBIFNGB(int AFJBIFLMHDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x44ECD10", Offset = "0x44EBD10", VA = "0x1844ECD10")]
	private bool ECEIHMNAJDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x44ECF00", Offset = "0x44EBF00", VA = "0x1844ECF00")]
	public bool HNEILIJEPGH(int NGLFEFNBMMA, [Out] T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x430ACE0", Offset = "0x4309CE0", VA = "0x18430ACE0")]
	public MJLBDDEDJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AJBCPJDFDKE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct AKFJCNMBONA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T JMEAFIDIDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int BLDMFCKMODI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<AKFJCNMBONA> HBBBNEHNIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T BLIJCFJJBIA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x35E3D10", Offset = "0x35E2D10", VA = "0x1835E3D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D20EC0", Offset = "0x3D1FEC0", VA = "0x183D20EC0")]
	public bool HODGCICEPOA(T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3D20D40", Offset = "0x3D1FD40", VA = "0x183D20D40")]
	public void GKAGDNHKNII(T JJCEIJMGOAB, int NGLFEFNBMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D20B50", Offset = "0x3D1FB50", VA = "0x183D20B50")]
	public bool FFDBNDOHLIO(T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D21250", Offset = "0x3D20250", VA = "0x183D21250")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D20940", Offset = "0x3D1F940", VA = "0x183D20940")]
	public T DLDHKKEOAEJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D205D0", Offset = "0x3D1F5D0", VA = "0x183D205D0")]
	protected void BHGBOEDNCBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D212E0", Offset = "0x3D202E0", VA = "0x183D212E0")]
	public AJBCPJDFDKE()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[IDHMMACJAGM(JFBJMOOHBCL.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x694F500", Offset = "0x694E500", VA = "0x18694F500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x694F7D0", Offset = "0x694E7D0", VA = "0x18694F7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x694F6E0", Offset = "0x694E6E0", VA = "0x18694F6E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x694F450", Offset = "0x694E450", VA = "0x18694F450")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x694F720", Offset = "0x694E720", VA = "0x18694F720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x694F630", Offset = "0x694E630", VA = "0x18694F630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x694F3C0", Offset = "0x694E3C0", VA = "0x18694F3C0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4969C50", Offset = "0x4968C50", VA = "0x184969C50", Slot = "4")]
		public virtual T DDGOAHKCDPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class CGAODAAMKNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, PMHFDHNHHBJ> HIKFGCEOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly IDPKEELFKKI<PMHFDHNHHBJ> DAHIJEEEHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool MPLOLDHJBJG;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PMHFDHNHHBJ PGDNNDIICFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 APIDPGDEJLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xE10560", Offset = "0xE0F560", VA = "0x180E10560")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1117520", Offset = "0x1116520", VA = "0x181117520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 APMHHIHOCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1171890", Offset = "0x1170890", VA = "0x181171890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 HHJLDAOLNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x694DA60", Offset = "0x694CA60", VA = "0x18694DA60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x851810", Offset = "0x850810", VA = "0x180851810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int MMJDMJGMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8593D0", Offset = "0x8583D0", VA = "0x1808593D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x859750", Offset = "0x858750", VA = "0x180859750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x694DA80", Offset = "0x694CA80", VA = "0x18694DA80")]
	public CGAODAAMKNJ(Bounds NPIAPLFMCEA, Vector2[] PCDHLLMHFJB, int CDJNFKJMDJN, byte EFHNBALPFBO, float HFMOFGDIGCE = 0f, [Optional] IDPKEELFKKI<PMHFDHNHHBJ> DAHIJEEEHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x694D5C0", Offset = "0x694C5C0", VA = "0x18694D5C0")]
	public void HEPMKFJPHCE(Bounds NPIAPLFMCEA, Vector2[] PCDHLLMHFJB, int CDJNFKJMDJN, byte EFHNBALPFBO, float HFMOFGDIGCE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x694CB90", Offset = "0x694BB90", VA = "0x18694CB90")]
	public PMHFDHNHHBJ CENAGDCJFEG(byte HCALFJOJKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x694CAC0", Offset = "0x694BAC0", VA = "0x18694CAC0")]
	public void BKOMAIOOKIO(Vector3 LLLHNMGEKPM, float CANCNKMACDD, float GLBNLMKFMMH, List<byte> AMLFJAJDKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x694D5A0", Offset = "0x694C5A0", VA = "0x18694D5A0")]
	public void HBNBLDEPEFD(PMHFDHNHHBJ.KNHMCGMFDGE NPGIDEONNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x694D230", Offset = "0x694C230", VA = "0x18694D230")]
	public static int FKHKIGOFBIH(Vector2[] PCDHLLMHFJB, int CDJNFKJMDJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x694D000", Offset = "0x694C000", VA = "0x18694D000")]
	private PMHFDHNHHBJ EGJAODAFBPC(byte HCALFJOJKJO, PMHFDHNHHBJ.IIFPLCNMPOC MGAGJGPDFEG, PMHFDHNHHBJ EMOKCJBMKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x694CBF0", Offset = "0x694BBF0", VA = "0x18694CBF0")]
	private void DDLHFEJHLIF(PMHFDHNHHBJ EMOKCJBMKOL, Vector2[] PCDHLLMHFJB, int CJGLGFPNNDN, int MKOJLJEIIGJ, int KIGNHDDFMPH, int JKFKADGBMLL, float HFMOFGDIGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x694D380", Offset = "0x694C380", VA = "0x18694D380")]
	private void GHJPDCJHPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x694CFA0", Offset = "0x694BFA0", VA = "0x18694CFA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x694D320", Offset = "0x694C320", VA = "0x18694D320", Slot = "1")]
	~CGAODAAMKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class PMHFDHNHHBJ
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum IIFPLCNMPOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum KNHMCGMFDGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte BJDAIFPCLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 HOCBALNJMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 ODOBBFBPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 INBMIDHCIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 NDHBHOBHPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public IIFPLCNMPOC JPLDCCIDCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public PMHFDHNHHBJ EOBHJDGKNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<PMHFDHNHHBJ> NDKCAICDMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool BFCLHPEJPFN;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x694F320", Offset = "0x694E320", VA = "0x18694F320")]
	public PMHFDHNHHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x694F1F0", Offset = "0x694E1F0", VA = "0x18694F1F0")]
	public void MOFEODPEIPI(PMHFDHNHHBJ CDKDCIHMCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public void HBNBLDEPEFD(int NBJOKJOCMGK, KNHMCGMFDGE NPGIDEONNGF, int ICOALOKNPII = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x694EEA0", Offset = "0x694DEA0", VA = "0x18694EEA0")]
	public void BKOMAIOOKIO(List<byte> AMLFJAJDKAC, Vector3 LLLHNMGEKPM, float CANCNKMACDD, float GLBNLMKFMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x694F100", Offset = "0x694E100", VA = "0x18694F100")]
	public bool CPALDAOABBH(Vector3 GMKCAOILOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x694F130", Offset = "0x694E130", VA = "0x18694F130")]
	public bool FHGKDPNNPGA(Vector3 GMKCAOILOEC, float DBMFODCKMOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x694F160", Offset = "0x694E160", VA = "0x18694F160")]
	public void LFNNOPDGNGK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct CDLFKJBGEPA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> IEKJOJONGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool LJNAKGFAPCN;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x42D0330", Offset = "0x42CF330", VA = "0x1842D0330")]
			public CDLFKJBGEPA(List<Component> IEKJOJONGFC, bool LJNAKGFAPCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x51934F0", Offset = "0x51924F0", VA = "0x1851934F0")]
			public IHNPAIJDAMJ<T> EAJKDCOBAGF()
			{
				return default(IHNPAIJDAMJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x5193550", Offset = "0x5192550", VA = "0x185193550", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x5193550", Offset = "0x5192550", VA = "0x185193550", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct IHNPAIJDAMJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> IEKJOJONGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool LJNAKGFAPCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int HCALFJOJKJO;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T NIGOAHBKKGN
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x3F37630", Offset = "0x3F36630", VA = "0x183F37630", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x3F375C0", Offset = "0x3F365C0", VA = "0x183F375C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x3F37600", Offset = "0x3F36600", VA = "0x183F37600")]
			public IHNPAIJDAMJ(List<Component> IEKJOJONGFC, bool LJNAKGFAPCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x3F37500", Offset = "0x3F36500", VA = "0x183F37500", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x3F37510", Offset = "0x3F36510", VA = "0x183F37510", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3903340", Offset = "0x3902340", VA = "0x183903340", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6951220", Offset = "0x6950220", VA = "0x186951220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6951020", Offset = "0x6950020", VA = "0x186951020")]
		private void LFNNOPDGNGK(GameObject PKODOKGPNGI, bool HPJKELEMMFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6950F90", Offset = "0x694FF90", VA = "0x186950F90")]
		public static void LFNNOPDGNGK(GameObject PKODOKGPNGI, ToolHierarchyCache JLBEALEHLIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6950F80", Offset = "0x694FF80", VA = "0x186950F80")]
		public void LEMNFOJIMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2ED7C20", Offset = "0x2ED6C20", VA = "0x182ED7C20")]
		public void ONFGCOJANHA<T>(Action<T> JFOAFIPDIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2ED7B80", Offset = "0x2ED6B80", VA = "0x182ED7B80")]
		public T NHDDGHOHBKK<T>(bool LJNAKGFAPCN = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2ED7E50", Offset = "0x2ED6E50", VA = "0x182ED7E50")]
		public CDLFKJBGEPA<T> PDMAJIOKODD<T>(bool LJNAKGFAPCN = false) where T : class
		{
			return default(CDLFKJBGEPA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6950B40", Offset = "0x694FB40", VA = "0x186950B40")]
		public List<Component> BJMBAFEFFPC(Type HNGLFCFOHLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6950E90", Offset = "0x694FE90", VA = "0x186950E90", Slot = "4")]
		public bool Equals(ToolHierarchyCache PONGAOGJLMF, ToolHierarchyCache FOJLHADHAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6950F10", Offset = "0x694FF10", VA = "0x186950F10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache NOPFNIKINJA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class JGMOFGCENNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BPIECAEAGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int LAPEIGOLKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> DPNHKFLJNPF;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3899B20", Offset = "0x3898B20", VA = "0x183899B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T BKINHHIOKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x410D5C0", Offset = "0x410C5C0", VA = "0x18410D5C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T CIKMJGPEHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x410CF50", Offset = "0x410BF50", VA = "0x18410CF50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T BHMEKOPGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x410D470", Offset = "0x410C470", VA = "0x18410D470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x410D7C0", Offset = "0x410C7C0", VA = "0x18410D7C0")]
	public JGMOFGCENNF(int BPIECAEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x410D220", Offset = "0x410C220", VA = "0x18410D220")]
	public void GKAGDNHKNII(T IPJIOLNFMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x410D760", Offset = "0x410C760", VA = "0x18410D760")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x410D380", Offset = "0x410C380", VA = "0x18410D380")]
	public void HIBBEPINAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x410D560", Offset = "0x410C560", VA = "0x18410D560")]
	public void KGAFFFJEOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x410D750", Offset = "0x410C750", VA = "0x18410D750")]
	public void MBLIJAOIGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x410D040", Offset = "0x410C040", VA = "0x18410D040")]
	public List<T> DGKMBLGMFGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class HPFJCHKIACC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct LOOLLCPOGIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int BLDMFCKMODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T JMEAFIDIDGF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, LOOLLCPOGIP> PDKIFAKOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> CCEIANEBMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T OOLGFGOJGMB;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T NFNPMELFGHF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9A27E0", Offset = "0x9A17E0", VA = "0x1809A27E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3E095F0", Offset = "0x3E085F0", VA = "0x183E095F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool PJKLLPHHPED
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3E09570", Offset = "0x3E08570", VA = "0x183E09570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object LJMDLJOGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3E05650", Offset = "0x3E04650", VA = "0x183E05650")]
	public bool CPIPAMHCHDK(T JJCEIJMGOAB, object DJIBMMAIGPE, int NGLFEFNBMMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3E08BB0", Offset = "0x3E07BB0", VA = "0x183E08BB0")]
	public bool FDNJFPDHLCC(object DJIBMMAIGPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3E08D00", Offset = "0x3E07D00", VA = "0x183E08D00")]
	public bool HNEILIJEPGH(object DJIBMMAIGPE, [Out] T JJCEIJMGOAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3D34BC0", Offset = "0x3D33BC0", VA = "0x183D34BC0")]
	public void PKAGCAPLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3E06880", Offset = "0x3E05880", VA = "0x183E06880")]
	private bool ECEIHMNAJDA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3E09670", Offset = "0x3E08670", VA = "0x183E09670")]
	public HPFJCHKIACC()
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
