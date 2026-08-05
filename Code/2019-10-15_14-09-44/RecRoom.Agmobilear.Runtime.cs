using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ARFaceCoefficients : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31A760", Offset = "0x319560", VA = "0x18031A760")]
	public ARFaceCoefficients()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ARSelfieController : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31A760", Offset = "0x319560", VA = "0x18031A760")]
	public ARSelfieController()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RequireComponent(typeof(ARFace))]
public class ARKitBlendShapeVisualizer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private float m_CoefficientScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private SkinnedMeshRenderer m_SkinnedMeshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ARFace m_Face;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float coefficientScale
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x323560", Offset = "0x322360", VA = "0x180323560")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x528700", Offset = "0x527500", VA = "0x180528700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public SkinnedMeshRenderer skinnedMeshRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x18031B680")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24F9450", Offset = "0x24F8250", VA = "0x1824F9450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24F8EA0", Offset = "0x24F7CA0", VA = "0x1824F8EA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24F8EF0", Offset = "0x24F7CF0", VA = "0x1824F8EF0")]
	private void CreateFeatureBlendMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24F9200", Offset = "0x24F8000", VA = "0x1824F9200")]
	private void SetVisible(bool visible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24F9350", Offset = "0x24F8150", VA = "0x1824F9350")]
	private void UpdateVisibility()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24F9060", Offset = "0x24F7E60", VA = "0x1824F9060")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24F8FA0", Offset = "0x24F7DA0", VA = "0x1824F8FA0")]
	private void OnDisable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24F9120", Offset = "0x24F7F20", VA = "0x1824F9120")]
	private void OnSystemStateChanged(ARSessionStateChangedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24F9130", Offset = "0x24F7F30", VA = "0x1824F9130")]
	private void OnUpdated(ARFaceUpdatedEventArgs eventArgs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24F9290", Offset = "0x24F8090", VA = "0x1824F9290")]
	private void UpdateFaceFeatures()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24F9440", Offset = "0x24F8240", VA = "0x1824F9440")]
	public ARKitBlendShapeVisualizer()
	{
	}
}
namespace Cpp2IlInjected;

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
