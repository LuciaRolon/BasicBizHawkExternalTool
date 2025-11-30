namespace Net.MyStuff.MyTool;

using System.Drawing;
using System.Windows.Forms;

using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;

[ExternalTool("ExternalToolTest")]
public sealed class ExternalToolTestForm : ToolFormBase, IExternalToolForm
{
    [RequiredApi]
    public IEmulationApi? _maybeEmulationAPI { get; set; }
    private IEmulationApi EmulationAPI => _maybeEmulationAPI!;

    private Label lblGameName;

    protected override string WindowTitleStatic
        => "ExternalToolTest";

    public ExternalToolTestForm()
    {
        // executed once ever
        ClientSize = new Size(480, 320);
        SuspendLayout();
        lblGameName = new Label
        {
            AutoSize = true,
            Text = "Game Loaded: No game loaded.",
            Location = new Point(10, 10)
        };
        Controls.Add(lblGameName);
        ResumeLayout(performLayout: false);
        PerformLayout();
    }    

    public override void Restart()
    {
        // executed once after the constructor, and again every time a rom is loaded or reloaded
        string gameName = "Game Loaded: No game loaded.";
        if (EmulationAPI.GetGameInfo()?.Name != "Null")
        {
            gameName = "Game Loaded: " + EmulationAPI.GetGameInfo().Name;
        }
        lblGameName.Text = gameName;
    }

    protected override void UpdateAfter()
    {
        // executed after every frame (except while turboing, use FastUpdateAfter for that)
    }
}